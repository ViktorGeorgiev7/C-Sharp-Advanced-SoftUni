using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = arr[0];
            int col = arr[1];
            int[,] matrix = new int[row, col];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] rowsInput = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }
            }
            
            //solve
            List<int> biggestSumRows = new List<int>();
            List<int> biggestSumCols = new List<int>();
            int biggest = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (row - 1 == rows)
                {
                    break;
                }
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (col - 1 == cols)
                    {
                        break;
                    } 
                    
                    if (row -1 == rows)
                    {
                        break;
                    }

                    var maxSum = matrix[rows, cols] + matrix[rows + 1, cols] + matrix[rows, cols + 1] + matrix[rows+1, cols+1];
                    if (maxSum> biggest)
                    {
                        biggestSumRows.Clear();
                        biggestSumCols.Clear();
                        biggest = maxSum;
                        biggestSumRows.Add(matrix[rows, cols]);
                        biggestSumRows.Add(matrix[rows, cols+1]);
                        biggestSumCols.Add(matrix[rows+1, cols]);
                        biggestSumCols.Add(matrix[rows+1, cols+1]);
                    }

                    maxSum = 0;
                }
                
            }
            //print
            Console.Write(string.Join(" ",biggestSumRows));
            Console.WriteLine();
            Console.Write(string.Join(" ", biggestSumCols));
            Console.WriteLine();
            Console.WriteLine(biggest);
        }
    }
}
