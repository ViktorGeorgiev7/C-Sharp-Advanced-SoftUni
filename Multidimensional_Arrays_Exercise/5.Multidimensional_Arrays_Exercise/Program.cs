using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Multidimensional_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)//5,6;SoftUni;
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int rowlenght = arr[0];
            int collenght = arr[1];
            string[,] matrix = new string[rowlenght, collenght];
            string snake = Console.ReadLine();

            Queue<string> snak = new Queue<string>();
            Queue<string> copySnak = snak;
            foreach (char el in snake)
            {
                snak.Enqueue(el.ToString());
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (!snak.Any())
                {
                    foreach (char el in snake)
                    {
                        snak.Enqueue(el.ToString());
                    }
                }
                if (rows % 2 == 0  || rows == 0)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        if (!snak.Any())
                        {
                            foreach (char el in snake)
                            {
                                snak.Enqueue(el.ToString());
                            }
                        }
                        matrix[rows, cols] = snak.Dequeue();
                    }
                }
                else
                {
                    for (int cols = matrix.GetLength(1); cols > 0; cols--)
                    {
                        if (!snak.Any())
                        {
                            foreach (char el in snake)
                            {
                                snak.Enqueue(el.ToString());
                            }
                        }
                        matrix[rows, cols-1] = snak.Dequeue();
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }
    }
}
