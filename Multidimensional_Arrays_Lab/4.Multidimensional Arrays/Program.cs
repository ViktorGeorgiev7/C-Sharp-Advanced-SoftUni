using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nxn = int.Parse(Console.ReadLine());
            char[,] matrix = new char[nxn, nxn];
            bool check = false;
            List<char> rowsInput = new List<char>();
            bool specialCheck = false;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string input = Console.ReadLine();
                foreach (char symbols in input)
                {
                    rowsInput.Add(symbols);
                }
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }

                rowsInput.Clear();
            }

            char symbol = char.Parse(Console.ReadLine() ?? string.Empty);

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (specialCheck == true)
                    {
                        break;
                    }
                    if (symbol == matrix[rows,cols])
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        check = true;
                        specialCheck = true;
                        break;
                    }
                }
            }

            if (!check)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
