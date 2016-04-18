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
using System.Drawing.Imaging;
using System.Drawing;
using Exifacto;

namespace TestApp {
    class Program {
        static void Main(string[] args) {
            // Reading EXIF data from a file (image001.jpg is part of the Demo project)

            ExifData exif = new ExifData("image001.jpg");
            Console.WriteLine("Orientation:        " + exif.Orientation);
            Console.WriteLine("Photo Taken:        " + exif.DateTimeOriginal.ToString());
            Console.WriteLine("Camera Model:       " + exif.CameraModel);
            Console.WriteLine("Exposure Program:   " + exif.ExposureProgram.ToString());
            Console.ReadKey(false);
        }
    }
}
