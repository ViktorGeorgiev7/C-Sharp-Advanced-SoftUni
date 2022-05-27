using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            List<int> stak = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(stak);
            
            if (n != 0)
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
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
                            list.Add(stack.Pop());
                        }

                        Console.WriteLine(list.AsQueryable().Min());
                    }
                }
            }
        }
    }
}
