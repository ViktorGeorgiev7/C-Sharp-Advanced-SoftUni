using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<Team> league = new List<Team>();
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] placeHolders = input.Split(';');
                    switch (placeHolders[0])
                    {
                        case "Team":
                            league.Add(new Team(placeHolders[1]));
                            break;
                        case "Add":
                            if (league.Exists(x=>x.Name == placeHolders[1]))
                            {
                                league[league.FindIndex(x => x.Name == placeHolders[1])].AddPlayer(new Player(placeHolders[2],new Stats(int.Parse(placeHolders[3]), int.Parse(placeHolders[4]), int.Parse(placeHolders[5]), int.Parse(placeHolders[6]), int.Parse(placeHolders[7]))));//Add;Arsenal;Aaron_Ramsey;95;82;82;89;68
                            }
                            else
                            {
                                Console.WriteLine($"Team {placeHolders[1]} does not exist.");
                            }
                            break;
                        case "Remove":
                            if (league.Exists(x => x.Name == placeHolders[1]))
                            {
                                if (!league[league.FindIndex(x => x.Name == placeHolders[1])].RemovePlayer(placeHolders[2]))
                                {
                                    Console.WriteLine($"Player {placeHolders[2]} is not in {placeHolders[1]} team.");
                                }
                            }
                            break;
                        case "Rating":
                            if (league.Exists(x => x.Name == placeHolders[1]))
                            {
                                Console.WriteLine($"{placeHolders[1]} - " +league[league.FindIndex(x=>x.Name == placeHolders[1])].AverageRating);
                            }
                            else
                            {
                                Console.WriteLine($"Team {placeHolders[1]} does not exist.");
                            }
                            break;
                    }

                    input = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
