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
