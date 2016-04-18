using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exifacto.Lookup {
    /// <summary>
    /// Specifies the various camera orientations supported by the EXIF standard.
    /// </summary>
    public enum CameraOrientation {
        /// <summary>
        /// The specified file did not include EXIF camera orientation information.
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// The sky is at the top of the photo; the photographer's left is at the left of the photo.
        /// </summary>
        // SkyAtTheTop = 1,
        Normal = 1,
        /// <summary>
        /// (rare) The sky is at the top of the photo; the photographer's left is at the right of the photo.
        /// </summary>
        // ReverseSkyAtTheTop = 2,
        Reversed = 2,
        /// <summary>
        /// The sky is at the bottom of the photo; the photographer's left is at the right  of the photo.
        /// </summary>
        // SkyAtTheBottom = 3,
        UpsideDown = 3,
        /// <summary>
        /// (rare) The sky is at the bottom of the photo; the photographer's left is at the left of the photo.
        /// </summary>
        // ReverseSkyAtTheBottom = 4,
        Inverted = 4,
        /// <summary>
        /// (rare) The sky is on the left; the photographer's left is at the top. (Camera rotated 90° counterclockwise, then photograph reversed)
        /// </summary>
        ReverseSkyOnTheLeft = 5,
        /// <summary>
        /// The sky is on the left; the photograph's left is at the top. (Camera rotated 90° clockwise from photographer's perspective)
        /// </summary>
        LeftSideOfCameraTowardsSky = 6,
        /// <summary>
        /// (rare) The sky is on the right; the photographer's left is at the top. (Camera rotated 90° clockwise, then photograph reversed)
        /// </summary>
        ReverseSkyOnTheRight = 7,
        /// <summary>
        /// The sky is on the right; the photographer's left is at the bottom. (Camera rotated 90° counterclockwise from photographer's perspective)
        /// </summary>
        LeftSideOfCameraTowardsGround = 8
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
