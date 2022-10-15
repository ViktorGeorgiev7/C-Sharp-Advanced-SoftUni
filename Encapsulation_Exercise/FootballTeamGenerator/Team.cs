using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private List<Player> team;
        private string name;

        public Team(string name)
        {
            Name = name;
            this.team = new List<Player>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int AverageRating => (int)Math.Round(team.Average(x => x.Stats.Average));

        public void AddPlayer(Player player)=>
        team.Add(player);

        public bool RemovePlayer(string name)
        {
            Player player = team.FirstOrDefault(x=>x.Name == name);
            return team.Remove(player);
        }
    }
}
