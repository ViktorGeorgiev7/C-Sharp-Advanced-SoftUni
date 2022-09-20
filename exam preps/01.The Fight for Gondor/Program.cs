using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plateArr = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> orcs = new Stack<int>();
            Stack<int> plates = new Stack<int>(plateArr.Reverse() ?? Array.Empty<int>());
            for (int i = 1; i <= n; i++)
            {
                int[] orcWave = Console.ReadLine()?
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (plates.Count <= 0)
                {
                    break;
                }
                if (i % 3 == 0)
                {
                    //plates.Push(int.Parse(Console.ReadLine()!));
                    int plate = int.Parse(Console.ReadLine());
                    var plateAsList = plates.ToList();
                    plateAsList.Add(plate);
                    plateAsList.Reverse();
                    plates = new Stack<int>(plateAsList);
                }

                foreach (var orc in orcWave)
                {
                    orcs.Push(orc);
                }

                while (orcs.Count > 0 && plates.Count>0)
                {
                    if (orcs.Peek() > plates.Peek())
                    {
                        int a = orcs.Pop() - plates.Pop();
                        orcs.Push(a);
                    }
                    else if(orcs.Peek() < plates.Peek())
                    {
                        int a = plates.Pop() - orcs.Pop();
                        plates.Push(a);
                    }
                    else
                    {
                        orcs.Pop();
                        plates.Pop();
                    }
                }
            }

            if (orcs.Any())
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ",orcs)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ",plates)}");
            }
        }
    }
}
