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
