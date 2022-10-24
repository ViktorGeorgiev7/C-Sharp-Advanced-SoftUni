using System;

namespace _2.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            FillMatrix(matrix);
            bool isDone = false;
            for (int i = 0; i < commands; i++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (isDone)
                    {
                        break;
                    }
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (isDone)
                        {
                            break;
                        }
                        if (matrix[row,col] == 'f')
                        {
                            switch (Console.ReadLine())
                            {
                                case "up":
                                    if (row==0)
                                    {
                                        if (matrix[n-1,col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[n - 1, col] = 'f';
                                        }
                                        else if (matrix[n-1,col] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[n - 1, col] = 'f';
                                        }
                                        else if (matrix[n-1,col] == 'B')
                                        {
                                            if (matrix[n-2, col] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[n - 2, col] = 'f';
                                        }
                                        else if (matrix[n-1,col] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row-1, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row - 1, col] = 'f';
                                        }
                                        else if (matrix[row-1, col] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[row - 1, col] = 'f';
                                        }
                                        else if (matrix[n - 1, col] == 'B')
                                        {
                                            if (matrix[n-2, col] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[row - 2, col] = 'f';
                                        }
                                        else if (matrix[row-1,col] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    break;
                                case "down":
                                    if (row == n-1)
                                    {
                                        if (matrix[0, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[0, col] = 'f';
                                        }
                                        else if (matrix[0, col] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[0, col] = 'f';
                                        }
                                        else if (matrix[0, col] == 'B')
                                        {
                                            if (matrix[1, col] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[1, col] = 'f';
                                        }
                                        else if (matrix[n - 1, col] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row+1, col] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row + 1, col] = 'f';
                                        }
                                        else if (matrix[row + 1, col] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[row + 1, col] = 'f';
                                        }
                                        else if (matrix[row + 1, col] == 'B')
                                        {
                                            if (matrix[row + 2, col] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[row+2, col] = 'f';
                                        }
                                        else if (matrix[row+1, col] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    break;
                                case "right":
                                    if (col == n-1)
                                    {
                                        if (matrix[row, 0] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, 0] = 'f';
                                        }
                                        else if (matrix[row, 0] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[row, 0] = 'f';
                                        }
                                        else if (matrix[row, 0] == 'B')
                                        {
                                            if (matrix[row, 1] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[row, 1] = 'f';
                                        }
                                        else if (matrix[row, 0] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row, col+1] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = 'f';
                                        }
                                        else if (matrix[row, col + 1] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = 'f';
                                        }
                                        else if (matrix[row, col+1] == 'B')
                                        {
                                            if (matrix[row, col + 2] == 'F')
                                            {
                                                isDone = true;
                                                matrix[row , col + 2] = 'f';
                                            }
                                            matrix[row, col] = '-';
                                            matrix[row, col+2] = 'f';
                                        }
                                        else if (matrix[row, col+1] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    break;
                                case "left":
                                    if (col == 0)
                                    {
                                        if (matrix[row, n-1] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, n - 1] = 'f';
                                        }
                                        else if (matrix[row, n - 1] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[row, n - 1] = 'f';
                                        }
                                        else if (matrix[row, n - 1] == 'B')
                                        {
                                            if (matrix[row, n-2] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[row, n-2] = 'f';
                                        }
                                        else if (matrix[row, n - 1] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    else
                                    {
                                        if (matrix[row, col -1] == '-')
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col - 1] = 'f';
                                        }
                                        else if (matrix[row, col - 1] == 'F')
                                        {
                                            isDone = true;
                                            matrix[row, col] = '-';
                                            matrix[row, col - 1] = 'f';
                                        }
                                        else if (matrix[row, col - 1] == 'B')
                                        {
                                            if (matrix[row, col-2] == 'F')
                                            {
                                                isDone = true;
                                            }
                                            matrix[row, col] = '-';
                                            matrix[row, col - 2] = 'f';
                                        }
                                        else if (matrix[row, col - 1] == 'T')
                                        {
                                            //leave empty as you don't change position anyway
                                        }
                                    }
                                    break;
                            }   
                        }
                    }
                }
                if (isDone)
                {//he wins
                    break;
                }
            }

            if (isDone)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player won!");
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                char[] arr = line.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
