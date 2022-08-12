using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _6.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<List<string>> printer = (s) => Console.WriteLine(string.Join("\n",s)) ;
            printer(arr);
        }

    }
}
