using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pile = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(pile);
            int counter = 0;
            int sum = 0;

            while(stack.Count>-1)
            {
                while (sum < capacity+1)
                {
                    sum += stack.Pop();
                    if (sum == capacity && stack.Count > 0)
                    {
                        sum = 0;
                        counter++;
                    }
                    else if (stack.Count == 0)
                    {
                        counter++;
                    }
                    else if (sum+stack.Peek() > capacity )
                    {
                        counter++;
                        sum = 0;
                    }
                    
                    

                    if (stack.Count== 0)
                    {
                        break;
                    }
                    
                }

                break;
            }

            Console.WriteLine(counter);
        }
    }
}
