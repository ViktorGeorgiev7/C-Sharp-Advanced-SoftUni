using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Channels;

namespace Raiding
{
    public static class HeroAcademy
    {
        public static BaseHero hero;
        public static string[] array = {"Druid", "Paladin","Rogue","Warrior" };
        public static BaseHero CreateHero(string type, string name)
        {
            if (type == "Paladin")
            {
                hero = new Paladin(name);
                return hero;
            }
            if (type == "Druid")
            {
                hero = new Druid(name);
                return hero;
            }
            if (type == "Warrior")
            {
                hero = new Warrior(name);
                return hero;
            }
            if (type == "Rogue")
            {
                hero = new Rogue(name);
                return hero;
            }

            return null;
        }
    }
}
