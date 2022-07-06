using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace _1.Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];
            int[,] matrix = new int[rows,cols];

            for (rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[]  rowsInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;
            for (rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    sum += matrix[rows, cols];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
 