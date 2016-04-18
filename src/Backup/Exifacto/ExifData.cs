/* GNU General Public License version 3
 * 
 * Copyright 2009 Dylan Beattie http://www.dylanbeattie.net/
 * 
 * This file is part of Exifacto [http://code.google.com/p/exifacto/]
 * 
 * Exifacto is free software: you can redistribute it and/or modify it under the
 * terms of the GNU General Public License as published by the Free Software Foundation,
 * either version 3 of the License, or (at your option) any later version.
 * 
 * Exifacto is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. 
 * If not, see http://www.gnu.org/licenses/.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text;
using Exifacto.Lookup;

namespace Exifacto {

    /// <summary>
    /// A class that exposes EXIF metadata containing in compatible JPEG and TIFF image files.  
    /// Create a new ExifData instance based on each image or filename from which you want to extract data.
    /// <example>
    ///     For example, use the following code to read data from C:\my_image.jpg
    ///     <code>
    ///        ExifData exif = new ExifData(@"C:\my_image.jpg");
    ///     </code>
    /// </example>
    /// </summary>
    public class ExifData {
        private Dictionary<ExifTag, PropertyItem> exifDataItems = new Dictionary<ExifTag, PropertyItem>();

        /// <summary>
        /// Create a new instance of ExifData based on EXIF data from the specified <see cref="System.Drawing.Image" />
        /// </summary>
        public ExifData(Image image) {
            foreach (PropertyItem item in image.PropertyItems) exifDataItems.Add((ExifTag)item.Id, item);
        }

        /// <summary>
        /// Create a new instance of ExifData based on EXIF tags from the specified file.
        /// </summary>
        public ExifData(string filePath)
            : this(new Bitmap(filePath)) {
        }

        /// <summary>
        /// Description of the image as an ASCII string. (Unicode not supported).
        /// </summary>
        public string ImageDescription {
            get {
                return (GetExifAsciiString(ExifTag.ImageDescription));
            }
        }

        /// <summary>
        /// Name of the camera manufacturer
        /// </summary>
        public string CameraMake {
            get { return (GetExifAsciiString(ExifTag.Make)); }
        }

        /// <summary>
        /// The model or model number of the camera.
        /// </summary>
        public string CameraModel {
            get { return (GetExifAsciiString(ExifTag.Model)); }
        }

        /// <summary>
        /// The orientation of the camera relative to the captured scene.
        /// </summary>
        public CameraOrientation Orientation {
            get {
                return ((CameraOrientation)GetExifByte(ExifTag.Orientation));
            }
        }

        /// <summary>
        /// Gets the software/firmware information of the camera that took this photograph.
        /// </summary>
        public string Software {
            get { return (GetExifAsciiString(ExifTag.Software)); }
        }

        /// <summary>
        /// The date/time when the image was last modified.
        /// </summary>
        public DateTime? DateTimeModified {
            get { return (GetExifDateTime(ExifTag.DateTime)); }
        }

        /// <summary>
        /// Copyright information about the image.
        /// </summary>
        public string Copyright {
            get { return (GetExifAsciiString(ExifTag.Copyright)); }
        }

        /// <summary>
        /// Gets a string containing the Exif version used by this file.
        /// </summary>
        /// <remarks>Stored as 4 bytes representing ASCII characters. Exif v12.34 would be encoded as 1234</remarks>
        public string ExifVersion {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// When was the image originally taken? Null indicates that no date information is available (e.g. camera did not have a clock)
        /// </summary>
        public DateTime? DateTimeOriginal {
            get { return (GetExifDateTime(ExifTag.DateTimeOriginal)); }
        }

        /// <summary>
        /// Date/Time that the image was digitized (usually the same as <see cref="DateTimeOriginal"/>.)
        /// If null, indicates that no time information is available (e.g. camera did not have a clock)
        /// </summary>
        public DateTime? DateTimeDigitized {
            get { return (GetExifDateTime(ExifTag.DateTimeDigitized)); }
        }

        /// <summary>
        /// The exposure program (preset) used when the image was taken.
        /// </summary>
        public ExposureProgramSetting ExposureProgram {
            get { return ((ExposureProgramSetting)GetExifByte(ExifTag.ExposureProgram)); }
        }

        #region Conversion and parsing methods

        /// <summary>
        /// Gets the first byte of the value associated with the specified <see cref="ExifTag" />
        /// </summary>
        private byte GetExifByte(ExifTag tag) {
            if (exifDataItems.ContainsKey(tag)) {
                byte[] rawValues = exifDataItems[tag].Value;
                if (rawValues.Length > 1) return (rawValues[0]);
            }
            return (0);
        }

        /// <summary>
        /// Gets the string value associated with the specified <see cref="ExifTag" />
        /// </summary>
        private string GetExifAsciiString(ExifTag tag) {
            if (exifDataItems.ContainsKey(tag)) {
                return (Encoding.ASCII.GetString(exifDataItems[tag].Value));
            } else {
                return (String.Empty);
            }
        }

        private static string[] exifDateFormats = new String[] { 
			"yyyy:MM:dd HH:mm:ss",
			"yyyy:MM:dd HH:mm:ss tt",
            "yyyy:MM:dd HH:mm:ss\0",
			"yyyy:MM:dd HH:mm:ss tt\0"
		};


        /// <summary>
        /// Gets a nullable DateTime containing the date/time associated with the specified <see cref="ExifTag" />. Returns null if no valid date is found.
        /// </summary>
        private DateTime? GetExifDateTime(ExifTag tag) {
            string dateString = GetExifAsciiString(tag);
            DateTime dateTime;
            if (DateTime.TryParseExact(dateString, exifDateFormats, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out dateTime)) {
                return (dateTime);
            }
            return (null);
        }
        #endregion
    }
}
