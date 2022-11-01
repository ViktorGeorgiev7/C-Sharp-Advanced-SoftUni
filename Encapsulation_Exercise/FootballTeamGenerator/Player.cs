using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;
        private string name;

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Name = name;
            this.Shooting = shooting;
            this.Passing = passing;
            this.Dribble = dribble;
            this.Sprint = sprint;
            this.Endurance = endurance;
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
        private double Sprint
        {
            get
            {
                return sprint;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        private double Endurance
        {
            get
            {
                return endurance;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }
                else
                {
                    endurance = value;
                }
            }
        }

        private double Dribble
        {
            get
            {
                return dribble;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }
                dribble = value;
            }
        }

        private double Passing
        {
            get
            {
                return passing;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }
                passing = value;
            }
        }

        private double Shooting
        {
            get
            {
                return shooting;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }
                shooting = value;
            }
        }

        public double Average => (Dribble + Shooting + Sprint + Passing + Endurance) / 5;

    }
}
