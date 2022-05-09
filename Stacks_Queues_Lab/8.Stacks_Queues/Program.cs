using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _8.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int counter = 0;

            Queue<string> queue = new Queue<string>();

            while (input != "end")
            {
                if (input == "green")
                {
                    counter++;
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            int a = n*counter;
            if (a > queue.Count)
            {
                a = queue.Count;
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"{queue.Dequeue()} passed!");
            }

            Console.WriteLine($"{a} cars passed the crossroads.");
        }
    }
}
