using System;

namespace _02.Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {//reading char matrix and its bounds

            int n = int.Parse(Console.ReadLine()!);
            char[,] matrix = new char[n,n];
            int moleRow = 0;
            int moleCol = 0;
            int firstPortalRow = 0;
            int firstPortalCol = 0;
            int secondPortalRow = 0;
            int secondPortalCol = 0;
            int points = 0;
            int rr = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                var line = text?.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line![col];
                    if (matrix[row,col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }

                    if (matrix[row,col] == 'S' && rr == 0)
                    {
                        firstPortalCol = col;
                        firstPortalRow = row;
                        rr++;
                    }
                    else if(matrix[row, col] == 'S' && rr == 1)
                    {
                        secondPortalRow = row;
                        secondPortalCol = col;
                    }
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                int oldRow = moleRow;
                int oldCol = moleCol;
                switch (input)
                {
                    case "up":
                        moleRow--;
                        break;
                    case "down":
                        moleRow++;
                        break;
                    case "left":
                        moleCol--;
                        break;
                    case "right":
                        moleCol++;
                        break;
                }

                if (moleRow>=0 && moleRow<n && moleCol>=0 && moleCol<n)
                {
                    if (matrix[moleRow,moleCol] == 'S')//
                    {//After the Mole is teleported to the other special location, he loses three (3) points and both of the special locations dissapear.
                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        if (moleRow == firstPortalRow && moleCol == firstPortalCol)
                        {
                            matrix[secondPortalRow, secondPortalCol] = 'M';
                            moleRow = secondPortalRow;
                            moleCol = secondPortalCol;
                        }
                        else if(moleRow == secondPortalRow && moleCol == secondPortalCol)
                        {
                            matrix[firstPortalRow, firstPortalCol] = 'M';
                            moleRow = firstPortalRow;
                            moleCol = firstPortalCol;
                        }
                    }
                    else if (matrix[moleRow,moleCol] == '-')
                    {
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else if (char.IsDigit(matrix[moleRow,moleCol]))
                    {
                        points += matrix[moleRow, moleCol] - '0';
                        matrix[moleRow, moleCol] = 'M';

                    }

                    matrix[oldRow, oldCol] = '-';
                    if (points>=25)
                    {
                        break;
                    }
                }
                else
                {
                    moleRow = oldRow;
                    moleCol = oldCol;
                    Console.WriteLine($"Don't try to escape the playing field!");
                }

                input = Console.ReadLine();
            }

            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
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
