using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Channels;

namespace _3.Multidimensional_Array_Exercise
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
            if (row <3 && col <3)
            {
                
            }
            else
            {
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    int[] rowsInput = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = rowsInput[cols];
                    }
                }

                //solve 
                int startRowIndex = 0;
                int startColIndex = 0;
                BigInteger maxSum = 0;
                BigInteger biggest = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    if (row - 2 == rows)
                    {
                        break;
                    }
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        if (col - 2 == cols)
                        {
                            break;
                        }

                        if (row - 2 == rows)
                        {
                            break;
                        }

                        maxSum = matrix[rows + 2, cols + 2] + matrix[rows + 2, cols + 1] + matrix[rows + 1, cols + 2] + matrix[rows, cols + 2] + matrix[rows + 2, cols] + matrix[rows, cols] + matrix[rows + 1, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols + 1];
                        if (maxSum > biggest)
                        {
                            biggest = maxSum;
                            startRowIndex = rows;
                            startColIndex = cols;
                        }

                        maxSum = 0;
                    }

                }
                //print
                Console.WriteLine($"Sum = {biggest}");

                for (int rowg = startRowIndex; rowg <= startRowIndex + 2; rowg++)
                {
                    for (int colg = startColIndex; colg <= startColIndex + 2; colg++)
                    {
                        Console.Write($"{matrix[rowg, colg]} ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
