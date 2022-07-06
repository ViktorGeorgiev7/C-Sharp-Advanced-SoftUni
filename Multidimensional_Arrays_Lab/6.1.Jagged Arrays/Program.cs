using System;
using System.Linq;

namespace _6._1.Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = ReadJaggedArray(rows);
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] placeHolders = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string command = placeHolders[0];
                int row = int.Parse(placeHolders[1]);
                int col = int.Parse(placeHolders[2]);
                int value = int.Parse(placeHolders[3]);

                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    jagged[row][col] -= value;
                }

                input = Console.ReadLine();
            }
            PrintJaggedArray(jagged);
        }

        public static int[][] ReadJaggedArray(int rows)
        {
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            return jagged;
        }
        public static void PrintJaggedArray(int[][] jagged)
        {
            foreach (var t in jagged)
                Console.WriteLine(String.Join(" ", t));
        }
    }
}
