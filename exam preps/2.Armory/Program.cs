using System;

namespace _2.Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            char[,] matrix = new char[n, n];
            bool isDone = false;
            FillMatrix(matrix); 
            int sum = 0;
            int[] mirrors = FindMirrors(matrix);
            while (true)
            {
                if (isDone)//guided out of the armory
                {
                    Console.WriteLine("I do not need more swords!");
                    break;
                }

                if (sum >= 65)//reaches 65g threshold
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    break;
                }
                var command = Console.ReadLine();
                bool hasMoved = false;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (hasMoved)
                    {
                        break;
                    }
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (hasMoved)
                        {
                            break;
                        }
                        if (matrix[row,col] == 'A')
                        {
                            hasMoved = true;
                            switch (command)//wsad
                            {
                                case "up":
                                    if (row == 0)
                                    {
                                        matrix[row, col] = '-';
                                        isDone = true;
                                    }
                                    else
                                    {
                                        if (char.IsNumber(matrix[row-1,col]))
                                        {
                                            sum += int.Parse(matrix[row - 1, col].ToString());
                                            matrix[row, col] = '-';
                                            matrix[row - 1, col] = 'A';
                                        }
                                        else if (matrix[row-1,col] == 'M')//make mirrors work******
                                        {
                                            matrix[row, col] =  '-';
                                            matrix[row - 1, col]  = '-';
                                            matrix[mirrors[2], mirrors[3]] = 'A';
                                        }
                                        else
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row - 1, col] = 'A';
                                        }
                                    }
                                    break;
                                case "down":
                                    if (row == n-1)
                                    {
                                        matrix[row, col] = '-';
                                        isDone = true;
                                    }
                                    else
                                    {
                                        if (char.IsNumber(matrix[row + 1, col]))
                                        {
                                            sum += int.Parse(matrix[row + 1, col].ToString());
                                            matrix[row, col] = '-';
                                            matrix[row +1, col] = 'A';
                                        }
                                        else if (matrix[row + 1, col] == 'M')//make mirrors work******
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row + 1, col] = '-';
                                            matrix[mirrors[2], mirrors[3]] = 'A';
                                        }
                                        else
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row + 1, col] = 'A';
                                        }
                                    }
                                    break;
                                case "left":
                                    if (col == 0)
                                    {
                                        matrix[row, col] = '-';
                                        isDone = true;
                                    }
                                    else
                                    {
                                        if (char.IsNumber(matrix[row, col-1]))
                                        {
                                            sum += int.Parse(matrix[row, col-1].ToString());
                                            matrix[row, col] = '-';
                                            matrix[row, col-1] = 'A';
                                        }
                                        else if (matrix[row, col-1] == 'M')//make mirrors work******
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col-1] = '-';
                                            matrix[mirrors[2], mirrors[3]] = 'A';
                                        }
                                        else
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col-1] = 'A';
                                        }
                                    }
                                    break;
                                case "right":
                                    if (col == n-1)
                                    {
                                        matrix[row, col] = '-';
                                        isDone = true;
                                    }
                                    else
                                    {
                                        if (char.IsNumber(matrix[row, col+1]))
                                        {
                                            sum += int.Parse(matrix[row, col + 1].ToString());
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = 'A';
                                        }
                                        else if (matrix[row, col + 1] == 'M')//make mirrors work******
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = '-';
                                            matrix[mirrors[2], mirrors[3]] = 'A';
                                        }
                                        else
                                        {
                                            matrix[row, col] = '-';
                                            matrix[row, col + 1] = 'A';
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }

            }

            Console.WriteLine($"The king paid {sum} gold coins.");
            PrintMatrix(matrix);
        }

        private static int[] FindMirrors(char[,] matrix)
        {
            int[] arr = new int[4];
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 'M' && count == 0)
                    {
                        arr[0] = row;
                        arr[1] = col;
                        count++;
                    }
                    else if(matrix[row,col] == 'M')
                    {
                        arr[2] = row;
                        arr[3] = col;
                    }
                }
            }

            return arr;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                var arr = line?.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr![col];
                }
            }
        }
    }
}
