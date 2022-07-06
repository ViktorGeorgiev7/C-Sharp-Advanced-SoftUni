using System;
using System.Linq;

namespace _2.Multidimensional_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int[] arr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = arr[0];
            int col = arr[1];
            int[,] matrix = new int[row, col];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] rowsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }
            }

            int count = 0;
            //solve
            
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

                    if (row - 1 == rows)
                    {
                        break;
                    } 

                    if (matrix[rows + 1, cols] == matrix[rows, cols] && matrix[rows, cols + 1] == matrix[rows, cols] && matrix[rows + 1, cols + 1] == matrix[rows, cols])
                    {
                        count++;
                    }
                } 
            }

            Console.WriteLine(count);
        }
    }
}
