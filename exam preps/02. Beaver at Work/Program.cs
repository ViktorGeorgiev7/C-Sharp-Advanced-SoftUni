using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    class Program
    {
        private static int beaverRow;
        private static int beaverCol;
        private static char[,] matrix;
        private static string lastDirection;

        private static List<char> branches = new List<char>();
        private static int totalBranches = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new char[n, n];

            FillMatrix(matrix);
            string direction = Console.ReadLine();
            while (direction != "end")
            {
                lastDirection = direction;
                switch (direction)
                {
                    case "up":
                        Move(-1,0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                    case "left":
                        Move(0, -1);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                }
                if (totalBranches == 0)
                {
                    break;
                }
                direction = Console.ReadLine();
            }

            Console.WriteLine(totalBranches > 0
                ? $"The Beaver failed to collect every wood branch. There are {totalBranches} branches left."
                : $"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((char)matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(beaverRow+row,beaverCol + col))
            {
                if (branches.Any())
                {
                    branches.Remove(branches[^1]);
                }
                return;
            }

            matrix[beaverRow, beaverCol] = '-';
            beaverRow += row;
            beaverCol += col;
            if (char.IsLower(matrix[beaverRow,beaverCol]))
            {
                branches.Add(matrix[beaverRow,beaverCol]);
                matrix[beaverRow, beaverCol] = 'B';
                totalBranches--;
            }
            else if (matrix[beaverCol,beaverRow] == 'F')
            {
                if (lastDirection == "up")
                {
                    if (beaverRow == 0)
                    {
                        if (char.IsLower(matrix[matrix.GetLength(1),beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(1), beaverCol]);
                            totalBranches--;
                        }

                        beaverRow = matrix.GetLength(0) - 1;
                        matrix[matrix.GetLength(1), beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[matrix.GetLength(1), beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(1), beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if(lastDirection == "down")
                {
                    if (beaverRow == matrix.GetLength(0)-1)
                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            branches.Add(matrix[0, beaverCol]);
                            totalBranches--;
                        }

                        beaverRow = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[matrix.GetLength(1)-1, beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(1)-1, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = matrix.GetLength(1)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection == "left")
                {
                    if (beaverCol == 0)
                    {
                        if (char.IsLower(matrix[beaverRow, matrix.GetLength(1)-1]))
                        {
                            branches.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            totalBranches--;
                        }

                        beaverCol = matrix.GetLength(1)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, 0]))
                        {
                            branches.Add(matrix[beaverRow, 0]);
                            totalBranches--;
                        }
                        beaverCol = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection == "right")
                {
                    if (beaverCol == matrix.GetLength(1)-1)
                    {
                        if (char.IsLower(matrix[beaverRow,0]))
                        {
                            branches.Add(matrix[beaverRow, 0]);
                            totalBranches--;
                        }

                        beaverCol = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, matrix.GetLength(1)-1]))
                        {
                            branches.Add(matrix[beaverRow, matrix.GetLength(1)-1]);
                            totalBranches--;
                        }
                        beaverCol = matrix.GetLength(1)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
            }
            else
            {
                matrix[beaverRow, beaverCol] = 'B';
            }
        }

        private static void FillMatrix(char[,] chars)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()!
                    .Replace(" ", "")
                    .ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row,col] == 'B')
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                    else if (char.IsLower(matrix[row,col]))
                    {
                        totalBranches++;
                    }
                }
            }
        }

        private static bool IsInside(int row,int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
    }
}
