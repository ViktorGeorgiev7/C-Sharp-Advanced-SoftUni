using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle:Shape
    {
        public Rectangle(double heightt,double widthh)
        {
            Height = heightt;
            Width = widthh;
        }
        public double Height { get; protected set; }
        public double Width { get; set; }
        public override double CalculatePerimiter()
        {
            return this.Height*2+this.Width*2;
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }
        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Width - 1; ++i)
                DrawLine(this.Width, '*', ' ');
            DrawLine(this.Width, '*', '*');
            return null;
        }
        private void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

    }
}
