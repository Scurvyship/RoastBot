﻿using System.Drawing;

namespace RoastBot.Objects
{
    class Fov
    {
        public Point Resolution { get; set; }

        public Rectangle FieldOfView { get; set; }

        public Point RangeValues { get; set; }

        public Point Tolerance { get; set; }
    }
}
