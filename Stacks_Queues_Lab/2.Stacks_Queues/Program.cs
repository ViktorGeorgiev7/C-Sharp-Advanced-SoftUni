using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                Stack<int> numbers = new Stack<int>(arr);
            
            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] placeHolders = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = placeHolders[0].ToLower();

                if (command == "add")
                {
                    int num1 = int.Parse(placeHolders[1]);
                    int num2 = int.Parse(placeHolders[2]);
                    numbers.Push(num1);
                    numbers.Push(num2);
                }
                else if (command == "remove")
                {
                    int a = int.Parse(placeHolders[1]);
                    if (numbers.Count < a)
                    {
                        
                    }
                    else
                    {
                        while (a > 0)
                        {
                            numbers.Pop();
                            a--;
                        }
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
