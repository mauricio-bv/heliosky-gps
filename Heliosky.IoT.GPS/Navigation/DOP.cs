﻿/*   DOP.cs
 *   Copyright (C) 2016 Gilang M. Hamidy (gilang.hamidy@gmail.com)
 *   
 *   This file is part of Heliosky.IoT.GPS
 * 
 *   Heliosky.IoT.GPS is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   Heliosky.IoT.GPS is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Lesser General Public License for more details.
 *
 *   You should have received a copy of the GNU Lesser General Public License
 *   along with Heliosky.IoT.GPS.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Heliosky.IoT.GPS.Navigation
{
    [UBXMessage(0x01, 0x04, MessageType.Receive | MessageType.Poll)]
    public class DOP : UBXModelBase
    {
        [UBXField(0)]
        public uint TimeMillisOfWeek { get; set; }

        [UBXField(1)]
        public ushort Geometric { get; set; }

        [UBXField(2)]
        public ushort Position { get; set; }

        [UBXField(3)]
        public ushort Time { get; set; }

        [UBXField(4)]
        public ushort Vertical { get; set; }

        [UBXField(5)]
        public ushort Horizontal { get; set; }

        [UBXField(6)]
        public ushort Northing { get; set; }

        [UBXField(7)]
        public ushort Easting { get; set; }
    }
}
