using System;
using System.Collections.Generic;
using System.Text;
namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine() ?? string.Empty);
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine() ?? string.Empty);
            var height = int.Parse(Console.ReadLine() ?? string.Empty);
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();
        }
    }
}
