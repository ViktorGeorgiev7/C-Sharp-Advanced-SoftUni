using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Threading;

namespace _02._Help_A_Mole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n,n];

            FillMatrix(field,n);
            int[] mole = FindMole(field);//Make points and teleportation system
            string move = Console.ReadLine();
            int points = 0;
            while (move != "End" && points < 25)//char[,] matrix,string move,int[] mole/*FindMole()*/,int n/* size*/
            {
                MakeMove(field, move, FindMole(field), n,points,FindTeleporters(field));
                move = Console.ReadLine();
            }

            if (points>=25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }

                Console.WriteLine();
            }
        }

        public static int[] FindMole(char[,] matrix)
        {
            int[] coordinates = new[]{0,0};

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] == 'M')
                    {
                        coordinates[0] = r;
                        coordinates[1] = c;
                    }
                }
            }

            return coordinates;
        }

        public static char[,] FillMatrix(char[,] matrix,int n)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string input = Console.ReadLine();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = input![c];
                }
            }

            return matrix;
        }

        public static int[] FindTeleporters(char[,] matrix)
        {
            int[] arr = {0, 0, 0, 0};
            int count = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (char.IsLetter(matrix[r,c]))
                    {
                        if (count == 0)
                        {
                        arr[0] = r;
                        arr[1] = c;
                        count++;
                        }
                        else
                        {
                            arr[2] = r;
                            arr[3] = c;
                        }

                    }
                }
            }

            return arr;
        }


        public static void MakeMove(char[,] matrix,string move,int[] mole/*FindMole()*/,int n/* size*/,int points,int[] arr)
        {
            int r = mole[0];
            int c = mole[1];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    switch (move)
                    {
                        case "left":
                            if (mole[1] == 0)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                            }
                            else
                            {
                                if (Char.IsDigit(matrix[rows, cols - 1]))
                                {
                                    points += matrix[rows, cols - 1];
                                    matrix[rows, cols - 1] = 'M';
                                }
                                else if (char.IsLetter(matrix[rows, cols - 1]))
                                {
                                    if (arr[0] == rows && arr[1] == cols - 1)
                                    {
                                        matrix[arr[2], arr[3]] = 'M';
                                        matrix[rows, cols - 1] = '-';
                                        points -= 3;
                                    }
                                    else if (arr[2] == rows && arr[3] == cols-1)
                                    {
                                        matrix[arr[0], arr[1]] = 'M';
                                        matrix[rows, cols - 1] = '-';
                                        points -= 3;
                                    }
                                }
                                matrix[rows, cols] = '-';
                            }

                            break;
                        case "right":
                            if (mole[1] == n-1)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                            }
                            else
                            {
                                if (char.IsDigit(matrix[rows, cols]))
                                {
                                    points += matrix[rows, cols];
                                    matrix[rows, cols] = 'M';
                                }
                                else if (char.IsLetter(matrix[rows, cols]))
                                {
                                    if (arr[0] == rows && arr[1] == cols + 1)
                                    {
                                        matrix[arr[2], arr[3]] = 'M';
                                        matrix[rows, cols + 1] = '-';
                                        points -= 3;
                                    }
                                    else if (arr[2] == rows && arr[3] == cols+1)
                                    {
                                        matrix[arr[0], arr[1]] = 'M';
                                        matrix[rows, cols + 1] = '-';
                                        points -= 3;
                                    }
                                }
                                matrix[rows, cols] = '-';

                            }
                            break;
                        case "down":
                            if (mole[0] == n-1)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                            }
                            else
                            {
                                if (Char.IsDigit(matrix[rows, cols]))
                                {
                                    points += matrix[rows, cols];
                                    matrix[rows, cols - ] = 'M';
                                }
                                else if (char.IsLetter(matrix[rows+1, cols]))
                                {
                                    if (arr[0] == rows+1 && arr[1] == cols)
                                    {
                                        matrix[arr[2], arr[3]] = 'M';
                                        matrix[rows+1, cols] = '-';
                                        points -= 3;
                                    }
                                    else if (arr[2] == rows+1 && arr[3] == cols)
                                    {
                                        matrix[arr[0], arr[1]] = 'M';
                                        matrix[rows+1, cols] = '-';
                                        points -= 3;
                                    }
                                }
                                matrix[rows, cols] = '-';
                            }
                            break;
                        case "up":
                            if (mole[0] == 0)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                            }
                            else
                            {
                                if (Char.IsDigit(matrix[rows-1, cols]))
                                {
                                    points += matrix[rows-1, cols];
                                    matrix[rows-1, cols] = 'M';
                                }
                                else if (char.IsLetter(matrix[rows-1, cols]))
                                {
                                    if (arr[0] == rows-1 && arr[1] == cols)
                                    {
                                        matrix[arr[2], arr[3]] = 'M';
                                        matrix[rows-1, cols] = '-';
                                        points -= 3;
                                    }
                                    else if (arr[2] == rows-1 && arr[3] == cols)
                                    {
                                        matrix[arr[0], arr[1]] = 'M';
                                        matrix[rows-1, cols] = '-';
                                        points -= 3;
                                    }
                                }
                                matrix[rows, cols] = '-';
                            }
                            break;
                    }
                }
            }
        }
    }
}
