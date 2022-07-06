using System;

namespace _6.Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = ReadJaggedArray(rows);
            PrintJaggedArray(jagged);
        }

        public static void PrintJaggedArray(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }

                Console.WriteLine();
            }
        }
        public static int[][] ReadJaggedArray(int rows)
        {
            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine($"cols for rows?");
                int cols = int.Parse(Console.ReadLine());
                jagged[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    jagged[row][col] = int.Parse(Console.ReadLine());
                }
            }

            return jagged;
        }

    }
}
