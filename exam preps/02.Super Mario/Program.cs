using System;
using System.Data;

namespace _02.Super_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine()!);

            int rowCount = int.Parse(Console.ReadLine()!);

            char[][] matrix = new char[rowCount][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()?.ToCharArray();
                matrix[row] = input;
            }
            //works
            int doingRow = -1;
            int doingCol = -1;
            bool isDead = false;
            bool isSaved = false;
            string move = Console.ReadLine();
            while (true)//80/100-error probably when trying to move outside field and dying at the same time resulting in false coordinates
            {
                string[] placeHolders = move?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                char direction = char.Parse(placeHolders![0]);
                //spawn Bowser
                matrix[int.Parse(placeHolders[1])][ int.Parse(placeHolders[2])] = 'B';

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'M')
                        {
                            switch (direction)
                            {
                                case 'W':
                                    if (row == 0)//check for going outside the field
                                    {
                                        lives--; 
                                        if (lives <= 0) {
                                            doingRow = row;
                                            doingCol = col;
                                            isDead = true;
                                        }
                                    }
                                    else if (matrix[row-1][col] == 'B')//check for bowser fight
                                    {
                                        matrix[row][col] = '-';
                                        lives -= 2;
                                        lives--;
                                        if (lives <= 0) {
                                            doingRow = row - 1;
                                            doingCol = col;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row - 1][ col] = 'M';

                                    }
                                    else if(matrix[row - 1][ col] == '-')//check for moving forward
                                    {
                                        matrix[row][ col] = '-';
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row - 1;
                                            doingCol = col;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row - 1][ col] = 'M';
                                    }
                                    else if (matrix[row-1][col] == 'P')
                                    {
                                        lives--;
                                        isSaved = true;
                                        doingRow = row-1;
                                        doingCol = col; matrix[row][ col] = '-';
                                        matrix[row-1][ col] = '-';
                                    }
                                    break;
                                case 'S':
                                    if (row == rowCount-1)//check for going outside the field
                                    {
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col;
                                            isDead = true;
                                        }
                                    }
                                    else if (matrix[row + 1][ col] == 'B')//check for bowser fight
                                    {
                                        matrix[row][ col] = '-';
                                        lives -= 2;
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row + 1;
                                            doingCol = col;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row + 1][ col] = 'M';

                                    }
                                    else if (matrix[row + 1][ col] == '-')//check for moving forward
                                    {
                                        matrix[row][ col] = '-';
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row + 1;
                                            doingCol = col;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row + 1][ col] = 'M';
                                    }
                                    else if (matrix[row + 1][ col] == 'P')
                                    {
                                        lives--;
                                        isSaved = true;
                                        doingRow = row + 1;
                                        doingCol = col; 
                                        matrix[row][ col] = '-';
                                        matrix[row+1][ col] = '-';
                                    }
                                    break;
                                case 'A':
                                    if (col == 0)//check for going outside the field
                                    {
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col;
                                            isDead = true;
                                        }
                                    }
                                    else if (matrix[row][ col-1] == 'B')//check for bowser fight
                                    {
                                        matrix[row][ col] = '-';
                                        lives -= 2;
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col-1;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row][ col-1] = 'M';

                                    }
                                    else if (matrix[row][ col-1] == '-')//check for moving forward
                                    {
                                        matrix[row][ col] = '-';
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col-1;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row][ col-1] = 'M';
                                    }
                                    else if (matrix[row][col-1] == 'P')
                                    {
                                        lives--;
                                        isSaved = true;
                                        doingRow = row;
                                        doingCol = col-1; 
                                        matrix[row][ col] = '-';
                                        matrix[row][ col - 1] = '-';
                                    }
                                    break;
                                case 'D':
                                    if (col == 4)//check for going outside the field
                                    {
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col;
                                            isDead = true;
                                        }
                                    }
                                    else if (matrix[row][ col+ 1] == 'B')//check for bowser fight
                                    {
                                        matrix[row][ col] = '-';
                                        lives -= 2;
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col +1;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row][ col +1] = 'M';

                                    }
                                    else if (matrix[row][ col+1] == '-')//check for moving forward
                                    {
                                        matrix[row][col] = '-';
                                        lives--;
                                        if (lives <= 0)
                                        {
                                            doingRow = row;
                                            doingCol = col +1;
                                            isDead = true;
                                            break;
                                        }
                                        matrix[row][ col +1] = 'M';
                                    }
                                    else if (matrix[row][ col +1] == 'P')
                                    {
                                        lives--;
                                        isSaved = true;
                                        doingRow = row;
                                        doingCol = col +1;
                                        matrix[row][ col] = '-';
                                        matrix[row][ col + 1] = '-';
                                    }
                                    break;
                            }
                        }
                    }
                }
                if (isSaved)
                    {
                        break;
                    }
                    if (isDead)
                    {
                        matrix[doingRow][ doingCol] = 'X';
                        break;
                    }
                move = Console.ReadLine();
            }

            if (isSaved)
            {
                Console.Write($"Mario has successfully saved the princess!");
                Console.WriteLine($" Lives left: {lives}");
            }
            else if(isDead)
            {
                Console.WriteLine($"Mario died at {doingRow};{doingCol}.");
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
