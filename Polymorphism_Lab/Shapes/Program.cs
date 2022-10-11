using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape;
            shape = new Circle(4);
            Console.WriteLine(shape.Draw());
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimiter());
            shape = new Rectangle(4, 5);
            Console.WriteLine(shape.Draw());
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimiter());
        }
    }
}
