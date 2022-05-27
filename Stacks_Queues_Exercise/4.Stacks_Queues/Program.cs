using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)//score:80/100
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int big = 0;
            Queue<int> queue = new Queue<int>(orders);
            for (int i = 0; i < orders.Length; i++)
            {
                if (food - queue.Peek() < 0)
                {
                    break;
                }
                if (food >= queue.Peek())
                {
                    if (big == 0)
                    {
                        big = queue.Peek();
                    }
                    else if (big < queue.Peek())
                    {
                        big = queue.Peek();
                    }
                    food -= queue.Dequeue();
                }
            }

            Console.WriteLine(big);

            Console.WriteLine(queue.Count < 1 ? "Orders complete" : $"Orders left: {string.Join(' ', queue)}");
        }
    }
}
