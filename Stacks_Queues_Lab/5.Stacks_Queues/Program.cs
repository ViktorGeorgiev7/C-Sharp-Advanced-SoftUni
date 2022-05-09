using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)//print even numbers from queue
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(arr);

            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    Console.WriteLine(queue.Dequeue());

                    
                }
                else
                {
                    if (queue.Peek() % 2 == 0)
                        Console.Write(queue.Dequeue() + ", ");
                    else
                    {
                        queue.Dequeue();
                    }
                }
            }
        }
    }
}
