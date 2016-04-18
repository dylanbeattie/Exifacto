using System;
using Exifacto;

namespace Demo {
    internal class Program {
        private static void Main(string[] args) {
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

/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2009-2016 Dylan Beattie http://www.dylanbeattie/net/
 * 
 * This file is part of Exifacto - http://www.github.com/dylanbeattie/Exifacto
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a 
 * copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation 
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the 
 * Software is furnished to do so, subject to the following conditions:
 * The above copyright notice and this permission notice shall be included 
 * in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR 
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 */
