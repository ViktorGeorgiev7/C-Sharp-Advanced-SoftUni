using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Sets_and_Dictionaries_Advanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
                
            }

            foreach (var student in students)
            {
                string gradeAsString = string.Join(" ", student.Value.Select(grade => grade.ToString("f2")));
                Console.WriteLine($"{student.Key} -> {string.Join(" ",gradeAsString)} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
