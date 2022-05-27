using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var original = new Queue<int>();

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                original.Enqueue(input[0]);
                original.Enqueue(input[1]);
            }

            while (true)
            {
                var copy =new Queue<int>(original);

                int liters = copy.Dequeue();
                int distance = copy.Dequeue();

                if (liters < distance)
                {
                    original.Enqueue(original.Dequeue());
                    original.Enqueue(original.Dequeue());
                }
                else if (liters>=distance)
                {
                    int fuelLeft = liters - distance;
                    while (copy.Any())
                    {
                        var litersInternal = copy.Dequeue();
                        var distanceInternal = copy.Dequeue();

                        if (liters+fuelLeft >= distanceInternal)
                        {
                            fuelLeft = litersInternal + fuelLeft - distanceInternal;
                        }
                        else
                        {
                            original.Enqueue(original.Dequeue());
                            original.Enqueue(original.Dequeue());
                            fuelLeft = -1;
                            break;
                        }
                    }

                    if (fuelLeft >= 0)
                    {
                        Console.WriteLine(index);
                        break;
                    }
                }

                index++;
            }
        }
    }
}
