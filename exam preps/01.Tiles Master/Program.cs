using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Tiles_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sinkArea = 40;
            const int ovenArea = 50;
            const int countertopArea = 60;
            const int wallArea = 70;
            Dictionary<string, int> map = new Dictionary<string, int>();
            map.Add("Sink",sinkArea);
            map.Add("Oven",ovenArea);
            map.Add("Countertop",countertopArea);
            map.Add("Wall",wallArea);
            Stack<int> whiteTiles = new Stack<int>();
            Queue<int> greyTiles = new Queue<int>();

            int[] whiteTilesInput = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] greyTilesInput = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var t in whiteTilesInput!)
            {
                whiteTiles.Push(t);
            }
            foreach (var t in greyTilesInput!)
            {
                greyTiles.Enqueue(t);
            }
            Dictionary<string, int> locationsTiles = new Dictionary<string, int>();
            while (true)
            {
                if (!whiteTiles.Any() || !greyTiles.Any())
                {
                    break;
                }

                bool isFitting = false;
                if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    int largerTile = whiteTiles.Peek() + greyTiles.Peek();
                    foreach (var location in map)
                    {
                        if (location.Value == largerTile)
                        {
                            if (!locationsTiles.ContainsKey(location.Key))
                            {
                                locationsTiles.Add(location.Key, 1);
                            }
                            else
                            {
                                locationsTiles[location.Key]++;
                            }

                            isFitting = true;
                            break;
                        }
                    }

                    if (!isFitting)
                    {
                        if (!locationsTiles.ContainsKey("Floor"))
                        {
                            locationsTiles.Add("Floor", 1);
                        }
                        else
                        {
                            locationsTiles["Floor"]++;
                        }
                    }
                    if (whiteTiles.Any())
                    {
                        whiteTiles.Pop();
                    }
                    if (greyTiles.Any())
                    {
                        greyTiles.Dequeue();
                    }
                }
                else
                {
                    if (whiteTiles.Any())
                    {
                        whiteTiles.Push(whiteTiles.Pop()/2);
                    }
                    if (greyTiles.Any())
                    {
                        greyTiles.Enqueue(greyTiles.Dequeue());
                    }
                }
            }
            var whiteTilesLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ", whiteTiles);
            var greyTilesLeft = greyTiles.Count == 0 ? "none" : string.Join(", ", greyTiles);

            Console.WriteLine($"White tiles left: {whiteTilesLeft}");
            Console.WriteLine($"Grey tiles left: {greyTilesLeft}");
            foreach (var location in locationsTiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
