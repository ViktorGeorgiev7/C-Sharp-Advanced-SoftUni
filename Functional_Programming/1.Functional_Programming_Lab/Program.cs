using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Xml.Xsl;

namespace _1.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 
            List<int> list = new List<int>(arr);
            var sorted = list.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ",sorted.OrderBy(x=>x)));
        }
    }
}
