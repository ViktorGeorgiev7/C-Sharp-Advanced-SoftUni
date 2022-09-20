using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isTrue = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 != 0)
                {
                    break;
                }
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    stack.Push(input[i]);
                }

                else if (input[i] == ')')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isTrue = false;
                    }
                }

                else if (input[i] == '}')
                {
                    if (stack.Any())
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isTrue = false;
                    }
                }

                else if (input[i] == ']')
                {
                    if (stack.Any())
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isTrue = true;
                    }
                }
            }

            if (stack.Count == 0 && isTrue)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
