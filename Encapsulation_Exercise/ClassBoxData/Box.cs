using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box : IBox
    {
        public Box(double length,double width,double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
        public double SurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }
    }
}
