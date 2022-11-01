using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Raiding
{
    public class StartUp
    {
        private static string name;
        private static string type;
        private static List<BaseHero> list = new List<BaseHero>();
        private static int bossPower;
        static void Main(string[] args)
        {
            Input();
            int a = list.Sum(x => x.Power);
            foreach (BaseHero hero in list)
            {
                Console.WriteLine(hero.CastAbility());
            }

            Console.WriteLine(a >= bossPower ? "Victory!" : "Defeat...");
        }

        private static void Input()
        {
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            while (a<n)
            {
                name = Console.ReadLine();
                type = Console.ReadLine();
                if (HeroAcademy.CreateHero(type,name) != null)
                {
                    list.Add(HeroAcademy.CreateHero(type, name));
                    a++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            bossPower = int.Parse(Console.ReadLine());
        }
    }
}
