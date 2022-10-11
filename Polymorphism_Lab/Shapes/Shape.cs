using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        public abstract double CalculatePerimiter();
        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return null;
        }

    }
}
