using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace _3.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Func<string,bool> function = text => Char.IsUpper(text[0]);
            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            words = words.Where(function).ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);    
            }
            
        }
    }
}
