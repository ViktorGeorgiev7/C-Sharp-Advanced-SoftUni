using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Channels;

namespace _5.Functional_Programming_Lab
{
    class Pairs
    {
        public Pairs(string name,int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pairs> list = new List<Pairs>();

            int n = int.Parse(Console.ReadLine());

            char[] arr = {',', ' '};
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] placeHolders = command.Split(arr,StringSplitOptions.RemoveEmptyEntries);
                string name = placeHolders[0];
                int age = int.Parse(placeHolders[1]);
                list.Add(new Pairs(name,age));
            }

            string filterInput = Console.ReadLine();
            int numFilter = int.Parse(Console.ReadLine());
            string condition = Console.ReadLine();

            Func<Pairs,int, bool> filter = GetFilter(filterInput);
            list = list.Where(x => filter(x, numFilter)).ToList();
            Action<Pairs> printer = GetPrinter(condition);
            list.ForEach(printer);
        }

        private static Action<Pairs> GetPrinter(string condition)
        {
            switch (condition)
            {
                case "age":
                    return s => Console.WriteLine(s.Age);
                case "name":
                    return s => Console.WriteLine(s.Name);
                case "name age":
                    return s => Console.WriteLine(s.Name+" - "+s.Age);
                default: return null;
            }
        }

        private static Func<Pairs, int,bool> GetFilter(string filterInput)
        {
            switch (filterInput)
            {
                case "older":
                    return (studentPair, ageFilter) => studentPair.Age >= ageFilter;
                case "younger":
                    return (studentPair, ageFilter) => studentPair.Age < ageFilter;
                default: return null;
            }
        }
    }
}
