using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new Box(length,width,height);
            if (length <= 0)
            {
                Console.WriteLine($"Length cannot be zero or negative."); ;
                return;
            }
            if (width <= 0)
            {
                Console.WriteLine($"Width cannot be zero or negative.");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine($"Height cannot be zero or negative.");
                return;
            }
            Console.WriteLine("Surface Area - " + $"{box.SurfaceArea():f2}" + "\n" + "Lateral Surface Area - " + $"{box.LateralSurfaceArea():f2}" + "\n" + "Volume - " + $"{box.Volume():f2}");
        }
    }
}
