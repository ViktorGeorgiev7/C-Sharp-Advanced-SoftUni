using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace _9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] cmdArgs = Console.ReadLine()?.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine()?.Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line![col];
                }
            }
            int coals = CountCoals(matrix);
            bool isDone = false;
            bool isOver = false;
            int endRow = -1;
            int endCol = -1;
            Queue<string> commands = new Queue<string>(cmdArgs!);
            while (true)
            {
                if (!commands.Any())
                {
                    Console.WriteLine($"{coals} coals left. ({endRow}, {endCol})");
                    break;
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col] == 's')
                        {
                            switch (commands.Dequeue())//left, right, up, and down
                            {
                                case "up":
                                    if (row == 0)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row - 1, col] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row - 1, col] = 's';
                                        }
                                        else if (matrix[row - 1, col] == 'e')
                                        {
                                            isOver = true;
                                            matrix[row, col] = '*';
                                            matrix[row - 1, col] = 's'; 
                                            endCol = col;
                                            endRow = row-1;
                                        }
                                        else if(matrix[row - 1, col] == 'c')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row - 1, col] = 's';
                                            coals--;
                                            if (coals == 0)
                                            {
                                                endCol = col;
                                                endRow = row-1;
                                                isDone = true;
                                            }
                                        }
                                        if (!commands.Any())
                                        {
                                            matrix[row - 1, col] = '*';
                                            endCol = col;
                                            endRow = row-1;
                                        }
                                    }
                                    break;
                                case "down":
                                    if (row == n - 1)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row + 1, col] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row + 1, col] = 's';
                                        }
                                        else if (matrix[row + 1, col] == 'e')
                                        {
                                            isOver = true;
                                            matrix[row, col] = '*';
                                            matrix[row + 1, col] = 's';
                                            endCol = col;
                                            endRow = row+1;
                                        }
                                        else if (matrix[row + 1, col] == 'c')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row + 1, col] = 's';
                                            coals--;
                                            if (coals == 0)
                                            {
                                                endCol = col;
                                                endRow = row+1;
                                                isDone = true;
                                            }
                                        }
                                        if (!commands.Any())
                                        {
                                            matrix[row + 1, col] = '*';
                                            endCol = col;
                                            endRow = row+1;
                                        }
                                    }
                                    break;
                                case "left":
                                    if (col == 0)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row, col-1] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col-1] = 's';
                                        }
                                        else if (matrix[row, col-1] == 'e')
                                        {
                                            isOver = true;
                                            matrix[row, col] = '*';
                                            matrix[row, col-1] = 's';
                                            endCol = col-1;
                                            endRow = row;
                                        }
                                        else if (matrix[row, col-1] == 'c')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col-1] = 's';
                                            coals--;
                                            if (coals == 0)
                                            {
                                                endCol = col-1;
                                                endRow = row;
                                                isDone = true;
                                            }
                                        }
                                        if (!commands.Any())
                                        {
                                            matrix[row, col-1] = '*';
                                            endCol = col-1;
                                            endRow = row;
                                        }
                                    }
                                    break;
                                case "right":
                                    if (col == n - 1)
                                    {

                                    }
                                    else
                                    {
                                        if (matrix[row, col+1] == '*')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row , col + 1] = 's';
                                        }
                                        else if (matrix[row , col + 1] == 'e')
                                        {
                                            isOver = true;
                                            matrix[row, col] = '*';
                                            matrix[row, col + 1] = 's';
                                            endCol = col + 1;
                                            endRow = row;
                                        }
                                        else if (matrix[row, col + 1] == 'c')
                                        {
                                            matrix[row, col] = '*';
                                            matrix[row, col + 1] = 's';
                                            coals--;
                                            if (coals == 0)
                                            {
                                                endCol = col + 1;
                                                endRow = row;
                                                isDone = true;
                                            }
                                        }
                                        if (!commands.Any())
                                        {
                                            matrix[row, col+1] = '*';
                                            endCol = col+1;
                                            endRow = row;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }

                if (isDone)
                {//output add
                    Console.WriteLine($"You collected all coals! ({endRow}, {endCol})");
                    break;
                }

                if (isOver)
                {//output add
                    Console.WriteLine($"Game over! ({endRow}, {endCol})");
                    break;
                }
            }
        }

        public static int CountCoals(char[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 'c')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
