using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            List<int> queue = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Queue<int> stack = new Queue<int>(queue);

            if (n != 0)
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Dequeue();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {


                while (stack.Count > 0)
                {
                    if (stack.Contains(x))
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        //list.AsQueryable().Min();
                        List<int> list = new List<int>();
                        while (stack.Count > 0)
                        {
                            list.Add(stack.Dequeue());
                        }

                        Console.WriteLine(list.AsQueryable().Min());
                    }
                }
            }
        }
    }
}
