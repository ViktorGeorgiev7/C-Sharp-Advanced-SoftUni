using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle:Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; protected set; }

        public override double CalculatePerimiter()
        {
            return Math.PI * this.Radius*this.Radius;
        }

        public override double CalculateArea()
        {
            return 2 * Math.PI * Radius;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        sb.Append("*");
                    else
                        sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
