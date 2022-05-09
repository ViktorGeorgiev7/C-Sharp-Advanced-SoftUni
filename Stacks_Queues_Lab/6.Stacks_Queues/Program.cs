using System;
using System.Collections.Generic;

namespace _6.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count> 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(queue.Count + " people remaining.");
        }
    }
}
