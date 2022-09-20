using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] kvp;
            Family list = new Family();
            for (int i = 0; i < n; i++)
            {
                kvp = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(kvp[0], int.Parse(kvp[1]));
                list.AddMember(person);
            }

            foreach (var person in list.GetOldestMember())
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
            
        }
    }
}
