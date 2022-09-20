using System;
using System.Linq;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] firstdt = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //1992 05 31
            int[] seconddt = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//2016 06 17
            DateTime start = new System.DateTime(firstdt[0],firstdt[1],firstdt[2]);
            DateTime end = new System.DateTime(seconddt[0],seconddt[1],seconddt[2]);
            TimeSpan difference = end - start;
            int days = (int)difference.TotalDays;
            Console.WriteLine(Math.Abs(days));
        }
    }
}
