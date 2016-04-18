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
using System.Linq;
using System.Text;

namespace Exifacto {
    public enum ExifTag {
        /// <summary>
        /// The actual aperture value of lens when the image was taken.</summary>
        /// <remarks>Unit is APEX. To convert this value to ordinary F-number(F-stop), calculate this value's power of root 2 (=1.4142). For example, if the ApertureValue is '5', F-number is 1.41425 = F5.6.</remarks>
        ApertureValue = 0x9202,

        Artist = 0x013b,
        BatteryLevel = 0x828f,

        /// <summary>The number of bits per component for each pixel - one byte per channel.</summary>
        BitsPerSample = 0x0102,

        /// <summary>The APEX 'B' (or 'L') variable indicating brightness (luminance) of the photograph subject.</summary>
        BrightnessValue = 0x9203,

        CFAPattern = 0x828e,
        CFAPattern2 = 0xa302,

        CFARepeatPatternDim = 0x828d,

        /// <summary>The color space of the photograph</summary>
        ColorSpace = 0xa001,

        /// <summary>
        /// Byte array indicating the order of pixel data in the photo. 
        /// </summary>
        /// <remarks>
        /// 0x01 = Y
        /// 0x02 = Cb
        /// 0x03 = Cr
        /// 0x04 = Red
        /// 0x05 = Green
        /// 0x06 = Blue
        /// </remarks>
        ComponentsConfiguration = 0x9101,

        /// <summary>Approximate indication of JPEG compression ratio.</summary>
        CompressedBitsPerPixel = 0x9102,

        /// <summary>The compression method used to store the photo.</summary>
        /// <remarks>1 means no compression, 6 means JPEG compression.</remarks>
        Compression = 0x0103,
        
        /// <summary>Copyright information about the photo.</summary>
        Copyright = 0x8298,
        /// <summary>The date/time when this file was last modified.</summary>
        DateTime = 0x0132,
        /// <summary>The date/time when this photograph was first stored digitally.</summary>
        DateTimeDigitized = 0x9004,

        /// <summary>The date/time when this photograph was originally taken.</summary>
        DateTimeOriginal = 0x9003,

        /// <summary>The height of this image (in pixels)</summary>
        ExifImageHeight = 0xa003,
        /// <summary>The width of this image (in pixels)</summary>
        ExifImageWidth = 0xa002,

        /// <summary>Used for compatibility extensions to EXIF standard.</summary>
        ExifInteroperabilityOffset = 0xa005,

        /// <summary>Used to support extended values in EXIF standard</summary>
        ExifOffset = 0x8769,

        /// <summary>The Exif version in use by the photo.</summary>
        /// <remarks>Stored as four bytes containing the Exif version in ASCII = e.g Exif v2.1 is stored as 0210</remarks>
        ExifVersion = 0x9000,

        /// <summary>The APEX 'Ev' variable indicating exposure bias (compensation) value used when the photo was taken.</summary>
        ExposureBiasValue = 0x9204,


        /// <summary>
        /// Same as the IsoSpeedRatings but stored as an unsigned rational. Only used on Kodak cameras.
        /// </summary>
        /// <remarks>Note that this tag name is used for two tag IDs in most EXIF documentation.</remarks>
        ExposureIndex = 0x9215,

        /// <summary>
        /// Same as the IsoSpeedRatings but stored as an unsigned rational. Only used on Kodak cameras.
        /// </summary>
        /// <remarks>Note that this tag name is used for two tag IDs in most EXIF documentation.</remarks>
        ExposureIndex2 = 0xa215,

        /// <summary>
        /// The preset (program) used when this photograph was taken.<br />
        /// 1 = Manual<br />
        /// 2 = Program (normal)<br />
        /// 3 = Aperture Priority<br />
        /// 4 = Shutter Priority<br />
        /// 5 = Creative (slow)<br />
        /// 6 = High-Speed (action)<br />
        /// 7 = Portrait<br />
        /// 8 = Landscape<br/>
        /// </summary>
        ExposureProgram = 0x8822,

        /// <summary>
        /// The exposure time used when this photo was taken (how long was the shutter open?) - in seconds.
        /// </summary>
        ExposureTime = 0x829a,

        /// <summary>
        /// The type of device that originally created the photo. Usually 0x03, indicating a digital camera.
        /// </summary>
        FileSource = 0xa300,

        /// <summary>
        /// Was the flash used when taking the photo? 0 = no; 1 = fired; 5 = fired but no strobe return detected; 7 = flash fired and strobe detected.
        /// </summary>
        Flash = 0x9209,
        /// <summary>
        /// Undocumented.
        /// </summary>
        FlashEnergy = 0x920b,
        /// <summary>
        /// Undocumented.
        /// </summary>
        FlashEnergy2 = 0xa20b,

        /// <summary>
        /// If the image data is based on te FlashPix format, this indicates the version of FlashPix in use.
        /// </summary>
        FlashPixVersion = 0xa000,

        /// <summary>The F-stop (F-number) value in use when the image was taken.</summary>
        FNumber = 0x829d,

        /// <summary>The focal length of the lens used to take the photo, in millimetres.</summary>
        FocalLength = 0x920a,

        /// <summary>
        /// The unit of resolution used when storing the <see cref="FocalPlaneXResolution"/> and <see cref="FocalPlaneYResolution" /> values.
        /// </summary>
        FocalPlaneResolutionUnit = 0xa210,

        /// <summary>
        /// The effective horizontal resolution of the photo (affected by the resolution setting on the camera)
        /// </summary>
        /// <remarks>This is not always the same as the CCD native resolution - for example, if shooting
        /// VGA photographs on an 8 megapixel camera, the native and effective resolutions will be different.</remarks>
        FocalPlaneXResolution = 0xa20e,
        /// <summary>
        /// The effective vertical resolution of the photo (affected by the resolution setting on the camera)
        /// </summary>
        FocalPlaneYResolution = 0xa20f,

        GPSInfo = 0x8825,

        /// <summary>
        /// An ASCII string describing the image.
        /// </summary>
        ImageDescription = 0x010e,

        ImageHistory = 0x9213,
        ImageLength = 0x0101,
        ImageNumber = 0x9211,
        ImageWidth = 0x0100,
        InterColorProfile = 0x8773,
        Interlace = 0x8829,
        InteroperabilityIndex = 0x0001,
        InteroperabilityVersion = 0x0002,
        IPTCNAA = 0x83bb,
        ISOSpeedRatings = 0x8827,
        JpegIFByteCount = 0x0202,
        JpegIFOffset = 0x0201,
        JPEGTables = 0x015b,
        LightSource = 0x9208,
        Make = 0x010f,
        MakerNote = 0x927c,
        MaxApertureValue = 0x9205,
        MeteringMode = 0x9207,
        Model = 0x0110,
        NewSubfileType = 0x00fe,
        Noise = 0x920d,
        OECF = 0x8828,
        Orientation = 0x0112,
        PhotometricInterpretation = 0x0106,
        PlanarConfiguration = 0x011c,
        Predictor = 0x013d,
        PrimaryChromaticities = 0x013f,
        ReferenceBlackWhite = 0x0214,
        RelatedImageFileFormat = 0x1000,
        RelatedImageLength = 0x1001,
        RelatedImageWidth = 0x1001,
        RelatedSoundFile = 0xa004,
        ResolutionUnit = 0x0128,
        RowsPerStrip = 0x0116,
        SamplesPerPixel = 0x0115,
        SceneType = 0xa301,
        SecurityClassification = 0x9212,
        SelfTimerMode = 0x882b,
        SensingMethod = 0xa217,
        ShutterSpeedValue = 0x9201,
        Software = 0x0131,
        SpatialFrequencyResponse = 0x920c,
        SpatialFrequencyResponse2 = 0xa20c,
        SpectralSensitivity = 0x8824,
        StripByteConunts = 0x0117,
        StripOffsets = 0x0111,
        SubfileType = 0x00ff,
        SubIFDs = 0x014a,
        SubjectDistance = 0x9206,
        SubjectLocation = 0x9214,
        SubjectLocation2 = 0xa214,
        SubsecTime = 0x9290,
        SubsecTimeDigitized = 0x9292,
        SubsecTimeOriginal = 0x9291,
        TIFFEPStandardID = 0x9216,
        TileByteCounts = 0x0145,
        TileLength = 0x0143,
        TileOffsets = 0x0144,
        TileWidth = 0x0142,
        TimeZoneOffset = 0x882a,
        TransferFunction = 0x012d,
        UserComment = 0x9286,
        WhitePoint = 0x013e,
        XResolution = 0x011a,
        YCbCrCoefficients = 0x0211,
        YCbCrPositioning = 0x0213,
        YCbCrSubSampling = 0x0212,
        YResolution = 0x011b,

        /*
        ///<summary>Exposure time, given in seconds.</summary>
        ExposureTime = 33434,
        ///<summary>The F number.</summary>
        FNumber = 33437,
        ///<summary>The class of the program used by the camera to set exposure when the picture is taken.</summary>
        ExposureProgram = 34850,
        ///<summary>Indicates the spectral sensitivity of each channel of the camera used.</summary>
        SpectralSensitivity = 34852,
        ///<summary>Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.</summary>
        ISOSpeedRatings = 34855,
        ///<summary>Indicates the Opto-Electric Conversion Function (OECF) specified in ISO 14524.</summary>
        OECF = 34856,
        ///<summary>The version of the supported Exif standard.</summary>
        ExifVersion = 36864,
        ///<summary>The date and time when the original image data was generated.</summary>
        DateTimeOriginal = 36867,
        ///<summary>The date and time when the image was stored as digital data.</summary>
        DateTimeDigitized = 36868,
        ///<summary>Specific to compressed data, specifies the channels and complements PhotometricInterpretation</summary>
        ComponentsConfiguration = 37121,
        ///<summary>Specific to compressed data, states the compressed bits per pixel.</summary>
        CompressedBitsPerPixel = 37122,
        ///<summary>Shutter speed.</summary>
        ShutterSpeedValue = 37377,
        ///<summary>The lens aperture.</summary>
        ApertureValue = 37378,
        ///<summary>The value of brightness.</summary>
        BrightnessValue = 37379,
        ///<summary>The exposure bias.</summary>
        ExposureBiasValue = 37380,
        ///<summary>The smallest F number of the lens.</summary>
        MaxApertureValue = 37381,
        ///<summary>The distance to the subject, given in meters.</summary>
        SubjectDistance = 37382,
        ///<summary>The metering mode.</summary>
        MeteringMode = 37383,
        ///<summary>The kind of light source.</summary>
        LightSource = 37384,
        ///<summary>Indicates the status of flash when the image was shot.</summary>
        Flash = 37385,
        ///<summary>The actual focal length of the lens, in mm.</summary>
        FocalLength = 37386,
        ///<summary>Indicates the location and area of the main subject in the overall scene.</summary>
        SubjectArea = 37396,
        ///<summary>Manufacturer specific information.</summary>
        MakerNote = 37500,
        ///<summary>Keywords or comments on the image, complements ImageDescription.</summary>
        UserComment = 37510,
        ///<summary>A tag used to record fractions of seconds for the DateTime tag.</summary>
        SubsecTime = 37520,
        ///<summary>A tag used to record fractions of seconds for the DateTimeOriginal tag.</summary>
        SubsecTimeOriginal = 37521,
        ///<summary>A tag used to record fractions of seconds for the DateTimeDigitized tag.</summary>
        SubsecTimeDigitized = 37522,
        ///<summary>The Flashpix format version supported by a FPXR file.</summary>
        FlashpixVersion = 40960,
        ///<summary>The color space information tag is always recorded as the color space specifier.</summary>
        ColorSpace = 40961,
        ///<summary>Specific to compressed data, the valid width of the meaningful image.</summary>
        PixelXDimension = 40962,
        ///<summary>Specific to compressed data, the valid height of the meaningful image.</summary>
        PixelYDimension = 40963,
        ///<summary>Used to record the name of an audio file related to the image data.</summary>
        RelatedSoundFile = 40964,
        ///<summary>Indicates the strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds</summary>
        FlashEnergy = 41483,
        ///<summary>Records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.</summary>
        SpatialFrequencyResponse = 41484,
        ///<summary>Indicates the number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.</summary>
        FocalPlaneXResolution = 41486,
        ///<summary>Indicates the number of pixels in the image height (Y) direction per FocalPlaneResolutionUnit on the camera focal plane.</summary>
        FocalPlaneYResolution = 41487,
        ///<summary>Indicates the unit for measuring FocalPlaneXResolution and FocalPlaneYResolution.</summary>
        FocalPlaneResolutionUnit = 41488,
        ///<summary>Indicates the location of the main subject in the scene.</summary>
        SubjectLocation = 41492,
        ///<summary>Indicates the exposure index selected on the camera or input device at the time the image is captured.</summary>
        ExposureIndex = 41493,
        ///<summary>Indicates the image sensor type on the camera or input device.</summary>
        SensingMethod = 41495,
        ///<summary>Indicates the image source.</summary>
        FileSource = 41728,
        ///<summary>Indicates the type of scene.</summary>
        SceneType = 41729,
        ///<summary>Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used.</summary>
        CFAPattern = 41730,
        ///<summary>Indicates the use of special processing on image data, such as rendering geared to output.</summary>
        CustomRendered = 41985,
        ///<summary>Indicates the exposure mode set when the image was shot.</summary>
        ExposureMode = 41986,
        ///<summary>Indicates the white balance mode set when the image was shot.</summary>
        WhiteBalance = 41987,
        ///<summary>Indicates the digital zoom ratio when the image was shot.</summary>
        DigitalZoomRatio = 41988,
        ///<summary>Indicates the equivalent focal length assuming a 35mm film camera, in mm.</summary>
        FocalLengthIn35mmFilm = 41989,
        ///<summary>Indicates the type of scene that was shot.</summary>
        SceneCaptureType = 41990,
        ///<summary>Indicates the degree of overall image gain adjustment.</summary>
        GainControl = 41991,
        ///<summary>Indicates the direction of contrast processing applied by the camera when the image was shot.</summary>
        Contrast = 41992,
        ///<summary>Indicates the direction of saturation processing applied by the camera when the image was shot.</summary>
        Saturation = 41993,
        ///<summary>Indicates the direction of sharpness processing applied by the camera when the image was shot.</summary>
        Sharpness = 41994,
        ///<summary>This tag indicates information on the picture-taking conditions of a particular camera model.</summary>
        DeviceSettingDescription = 41995,
        ///<summary>Indicates the distance to the subject.</summary>
        SubjectDistanceRange = 41996,
        ///<summary>Indicates an identifier assigned uniquely to each image.</summary>
        ImageUniqueID = 42016
         * */
    }
}

