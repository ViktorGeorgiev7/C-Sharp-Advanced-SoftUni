using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle:IDrawable
    {
        private readonly int _radius;
        public Circle(int radius)
        {
            this._radius = radius;
        }
        public void Draw()
        {
            double rIn = this._radius - 0.4;
            double rOut = this._radius + 0.4;
            for (double y = this._radius; y >= -this._radius; --y)
            {
                for (double x = -this._radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
