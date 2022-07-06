using System;
using System.Linq;

namespace _4.Multidimensional_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int row = arr[0];
            int col = arr[1];
            string[,] matrix = new string[row, col];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] rowsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }
            }

            string input = Console.ReadLine();//swap row1 col1 row2 col2
            while (input != "END")
            {
                string[] placeHolders = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (placeHolders.Length == 5)
                {
                    string command = placeHolders[0];
                    int row1 = int.Parse(placeHolders[1]);
                    int col1 = int.Parse(placeHolders[2]);
                    int row2 = int.Parse(placeHolders[3]);
                    int col2 = int.Parse(placeHolders[4]);

                    if (command == "swap" && row1 <= row && row2<=row && col1<=col && col2<=col)
                    {
                        string a = matrix[row1, col1];
                        string b = matrix[row2, col2];
                        matrix[row1, col1] = b;
                        matrix[row2, col2] = a;

                        for (int rowg = 0; rowg <= matrix.GetLength(0)-1; rowg++)
                        {
                            for (int colg = 0; colg <= matrix.GetLength(1)-1; colg++)
                            {
                                Console.Write($"{matrix[rowg, colg]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
                

                input = Console.ReadLine();
            }
        }
    }
}
