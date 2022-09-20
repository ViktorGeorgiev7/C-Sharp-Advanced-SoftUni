using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";

            HashSet<char> pearSet = new HashSet<char>(pear.ToCharArray());
            HashSet<char> flourSet = new HashSet<char>(flour.ToCharArray());
            HashSet<char> porkSet = new HashSet<char>(pork.ToCharArray());
            HashSet<char> oliveSet = new HashSet<char>(olive.ToCharArray());

            List<char> volews = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToList();
            List<char> consonants = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToList();
            foreach (var volew in volews)
            {
                if (pearSet.Contains(volew))
                {
                    pearSet.Remove(volew);
                }
                if (porkSet.Contains(volew))
                {
                    porkSet.Remove(volew);
                }
                if (oliveSet.Contains(volew))
                {
                    oliveSet.Remove(volew);
                }
                if (flourSet.Contains(volew))
                {
                    flourSet.Remove(volew);
                }
            }

            bool isRemoved = false;
            foreach (var consonant in consonants.ToList())
            {
                isRemoved = false;
                if (pearSet.Contains(consonant))
                {
                    pearSet.Remove(consonant);
                    isRemoved = true;
                }
                if (porkSet.Contains(consonant))
                {
                    porkSet.Remove(consonant);
                    isRemoved = true;
                }
                if (flourSet.Contains(consonant))
                {
                    flourSet.Remove(consonant);
                    isRemoved = true;
                }
                if (oliveSet.Contains(consonant))
                {
                    oliveSet.Remove(consonant);
                    isRemoved = true;
                }

                if (isRemoved)
                {
                    consonants.Remove(consonant);
                }
            }

            List<string> list = new List<string>();
            if (!porkSet.Any())
            {
                list.Add(pork);
            }
            if (!pearSet.Any())
            {
                list.Add(pear);
            }
            if (!flourSet.Any())
            {
                list.Add(flour);
            }
            if (!oliveSet.Any())
            {
                list.Add(olive);
            }
            string[] wordsInOrder =
            {
                "pear",
                "flour",
                "pork",
                "olive"
            };
            Console.WriteLine($"Words found: {list.Count}");
            for (int i = 0; i < wordsInOrder.Length; i++)
            {
                if (list.Contains(wordsInOrder[i]))
                {
                    Console.WriteLine(wordsInOrder[i]);
                }
            }
        }
    }
}
