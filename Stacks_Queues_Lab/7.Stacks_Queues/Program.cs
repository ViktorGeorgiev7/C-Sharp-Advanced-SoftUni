using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> queue = new Queue<string>(arr);
            int n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
