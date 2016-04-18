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
    /// <summary>
    /// Specifies the various data formats that are encoded within EXIF tags.
    /// </summary>
    public enum ExifTagType {

        /// <summary>Data contains unsigned bytes</summary>
        UnsignedByte = 1,

        /// <summary>Data contains an ASCII-encoded string</summary>
        AsciiString = 2,

        /// <summary>Data contains unsigned 2-byte values</summary>
        UnsignedChar = 3,

        ///<summary>Data contains unsigned 4-byte values</summary>
        UnsignedInt = 4,

        /// <summary>Data contains a fraction represented as two unsigned ints; the first 4 bytes are the numerator, the second 4 bytes are the denominator</summary>
        UnsignedRational = 5,

        /// <summary>Data contains signed bytes</summary>
        SignedByte = 6,

        /// <summary>Data is in arbitrary tag-specific format</summary>
        Undefined = 7,

        /// <summary>Data contains signed 2-byte values</summary>
        SignedChar = 8,

        /// <summary>Data contains signed 4-byte values</summary>
        SignedInt = 9,
        
        /// <summary>Data contains a fraction represented as two signed ints; the first 4 bytes are the numerator, the second 4 bytes are the denominator</summary>
        SignedRational = 10,

        /// <summary>Data contains 4-byte floating point values</summary>
        Float = 11,
        
        /// <summary>Data contains 8-byte floating point values</summary>
        Double = 12
    }
}