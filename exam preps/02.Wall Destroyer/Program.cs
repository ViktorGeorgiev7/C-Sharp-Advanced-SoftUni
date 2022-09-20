using System;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Threading;

namespace _02.Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {//reading char matrix and its bounds

            int n = int.Parse(Console.ReadLine()!);
            char[,] matrix = new char[n,n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                var line = text?.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line![col];
                }
            }
            bool hitCable = false;
                int holes = 0;
                int rodeHit = 0;
            string move = Console.ReadLine();
            while (true)
            {
                if (hitCable)
                {
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {Counter(matrix)} hole(s).");
                    break;
                }
                if (move == "End")
                {
                    break;
                }

                bool IsFound = false;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col] == 'V')
                        {
                            if (IsFound)
                            {
                                break;
                            }
                            IsFound = true;
                            switch (move)
                            {
                                case "up":
                                    if (row == 0)
                                    {
                                        
                                    }
                                    else
                                    {
                                        if (matrix[row-1,col] == 'R')
                                        {
                                            Console.WriteLine("Vanko hit a rod!");
                                            rodeHit++;
                                        }
                                        else if (matrix[row - 1, col] == 'C')
                                        {
                                            matrix[row - 1, col] = 'E';
                                            holes++;
                                            matrix[row, col] = '*';
                                            hitCable = true;
                                        }
                                        else if (matrix[row - 1, col] == '-')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row - 1, col] = 'V';
                                            holes++;
                                        }
                                        else if (matrix[row -1, col] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row - 1, col] = 'V';
                                            Console.WriteLine($"The wall is already destroyed at position [{row-1}, {col}]!");//can u step on the wall?
                                        }
                                    }
                                    break;
                                case "down":
                                    if (row == n-1)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row + 1, col] == 'R')
                                        {
                                            Console.WriteLine("Vanko hit a rod!");
                                            rodeHit++;
                                        }
                                        else if (matrix[row +1, col] == 'C')
                                        {
                                            matrix[row +1, col] = 'E';
                                            holes++;
                                            matrix[row, col] = '*';
                                            hitCable = true;
                                        }
                                        else if (matrix[row +1, col] == '-')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row +1, col] = 'V';
                                            holes++;
                                        }
                                        else if (matrix[row +1, col] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row +1, col] = 'V'; 
                                            Console.WriteLine($"The wall is already destroyed at position [{row+1}, {col}]!");//can u step on the wall?
                                        }
                                    }
                                    break;
                                case "left":
                                    if (col == 0)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row , col - 1] == 'R')
                                        {
                                            rodeHit++; Console.WriteLine("Vanko hit a rod!");
                                        }
                                        else if (matrix[row , col-1] == 'C')
                                        {
                                            matrix[row, col-1] = 'E';
                                            holes++;
                                            matrix[row, col] = '*';
                                            hitCable = true;
                                        }
                                        else if (matrix[row, col - 1] == '-')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col - 1] = 'V';
                                            holes++;
                                        }
                                        else if (matrix[row, col-1] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col-1] = 'V'; 
                                            Console.WriteLine($"The wall is already destroyed at position [{row}, {col-1}]!");//can u step on the wall?
                                        }
                                    }
                                    break;
                                case "right":
                                    if (col == n-1)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row, col+1] == 'R')
                                        {
                                            Console.WriteLine("Vanko hit a rod!"); rodeHit++;
                                        }
                                        else if (matrix[row, col+1] == 'C')
                                        {
                                            matrix[row, col+1] = 'E';
                                            holes++;
                                            matrix[row, col] = '*';
                                            hitCable = true;
                                        }
                                        else if (matrix[row , col+1] == '-')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col+1] = 'V';
                                            holes++;
                                        }
                                        else if (matrix[row, col+1] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col+1] = 'V'; 
                                            Console.WriteLine($"The wall is already destroyed at position [{row}, {col+1}]!");//can u step on the wall?
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }

                move = Console.ReadLine();
            }

            if (!hitCable)
            {
                Console.WriteLine($"Vanko managed to make {Counter(matrix)} hole(s) and he hit only {rodeHit} rod(s).");
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }

        }

        static public int Counter(char[,] matrix)
        {
            int count = 0;
            for (int stiga = 0; stiga < matrix.GetLength(0); stiga++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[stiga, j] == '*')
                    {
                        count++;
                    }
                    else if (matrix[stiga, j] == 'E')
                    {
                        count++;
                    }
                    else if (matrix[stiga,j] == 'V')
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
