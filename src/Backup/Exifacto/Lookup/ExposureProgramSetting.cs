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


namespace Exifacto.Lookup {
    public enum ExposureProgramSetting {
        Unknown = 0,
        Manual = 1,
        ProgramNormal = 2,
        AperturePriority = 3,
        ShutterPriority = 4,
        SlowCreative = 5,
        HighSpeedAction = 6,
        Portrait = 7,
        Landscape = 8
    }
}
