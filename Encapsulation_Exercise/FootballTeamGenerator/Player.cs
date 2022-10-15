using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name,Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
        public Stats Stats
        {
            get
            {
                return stats;
            }
            set
            {
                stats = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

    }
}
