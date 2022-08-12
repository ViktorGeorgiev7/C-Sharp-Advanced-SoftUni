using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] contestPair = Console.ReadLine().Split(':',StringSplitOptions.RemoveEmptyEntries);

            while (contestPair[0] != "end of contests")
            {
                string contestName = contestPair[0];
                string contestPass = contestPair[1];
                dictionary.Add(contestName,contestPass);
                contestPair = Console.ReadLine().Split(':',StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                string student = tokens[2];
                int points = int.Parse(tokens[3]);
                foreach (var keyval in dictionary)
                {
                    if (contest == keyval.Key)
                    {
                        if (password == keyval.Value)
                        {
                            if (!dictionary.ContainsKey(student))
                            {
                               students.Add(student,new Dictionary<string, int>());   
                               students[student].Add(contest,points);
                            }
                            else if (dictionary.ContainsKey(student))
                            {
                                if (students[student][contest] < points)
                                {
                                    students[student][contest] = points;
                                }
                            }
                        }
                    }
                }
            }
            //print; to do
            var bestStudent = students.OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Best candidate is {bestStudent.First().Key} with total {bestStudent.First().Value.Values.Sum()} points.");
            Console.WriteLine($"Ranking:");
            
            foreach (var student in students.OrderBy(x=>x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }
    }
}
