using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int AreaFront
        {
            get => Width * Height;
        }

        public int AreaSide
        {
            get => Length * Height;
        }

        public int Volume
        {
            get => Length * Width * Height;
        }
    }
}
