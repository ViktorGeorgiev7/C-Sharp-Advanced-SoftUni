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
            string input = Console.ReadLine();
            Stack<char> reverse = new Stack<char>();

            foreach (char thing in input)
            {
                reverse.Push(thing);
            }

            while (reverse.Count != 0)
            {
                Console.Write(reverse.Pop());
            }
        }
    }
}
