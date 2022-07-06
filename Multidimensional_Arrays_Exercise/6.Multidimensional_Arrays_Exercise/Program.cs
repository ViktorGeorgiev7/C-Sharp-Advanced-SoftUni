using System;
using System.Linq;

namespace _6.Multidimensional_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            AnalyzeJaggedArray(rows);
        }
        public static int[][] ReadJaggedArray(int rows)
        {
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            return jagged;
        }

        public static int[][] AnalyzeJaggedArray(int rows)
        {
            int[][] jagged = ReadJaggedArray(rows);
            for (int row = 0; row+1 < rows; row++)
            {
                if (row < rows && jagged[row].Length == jagged[row + 1].Length)
                {//multiply the values of the 2 rows by 2
                    for (int currRow = row; currRow < row + 2; currRow++)
                    {
                        for (int cols = 0; cols < jagged[row].Length; cols++)
                        {
                            jagged[currRow][cols] *= 2;
                        }
                    }
                }
                else if (row < rows)
                {//divide the values of the 2 rows by 2
                    for (int currRow = row; currRow < row + 2; currRow++)
                    {
                        for (int cols = 0; cols < jagged[currRow].Length; cols++)
                        {
                            jagged[currRow][cols] /= 2;
                        }
                    }
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] placeHolders = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);//Add 0 10 10
                string command = placeHolders[0];
                int roww = int.Parse(placeHolders[1]);
                int column = int.Parse(placeHolders[2]);
                int value = int.Parse(placeHolders[3]);
                if (roww >= 0 && column >= 0 && command == "Add" && roww < rows && column < jagged[roww].Length)
                {
                    jagged[roww][column] += value;
                }
                else if(roww >= 0 && column >= 0 && command == "Subtract" && roww < rows && column < jagged[roww].Length)
                {
                    jagged[roww][column] -= value;
                }
                input = Console.ReadLine();
            }
            PrintJaggedArray(jagged);
            return jagged;
        }

        public static void PrintJaggedArray(int[][] jagged)
        {
            foreach (var t in jagged)
                Console.WriteLine(string.Join(" ", t));
        }
    }
}
