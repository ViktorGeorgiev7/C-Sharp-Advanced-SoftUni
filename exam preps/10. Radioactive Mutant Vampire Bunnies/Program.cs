using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = arr![0];
            int m = arr[1];
            char[,] matrix = new char[n, m];

            FillMatrix(matrix);
            string line = Console.ReadLine();
            char[] cmdArgs = line?.ToCharArray();
            Queue<char> commands = new Queue<char>(cmdArgs);

            while (true)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col] == 'B')
                        {
                            
                        }
                        else if (matrix[row,col]=='P')
                        {
                            
                        }
                    }
                }
            }
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                var line = text?.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line![col];
                }
            }
        }
    }
}
