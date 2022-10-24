using System;
using System.ComponentModel.Design;
using System.Data;

namespace _02.Super_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine()!);

            int rowCount = int.Parse(Console.ReadLine()!);
            int currentRow = 0;
            int currentCol = 0;
            char[][] matrix = new char[rowCount][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()?.ToCharArray();
                matrix[row] = input;//find mario in the matrix
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'M')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }//find mario indices

            bool isDead = false;

            while (true)
            {
                string[] move = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                matrix[int.Parse(move[1])][int.Parse(move[2])] = 'B';
                int oldRow = currentRow;
                int oldCol = currentCol;
                switch (move[0])
                {
                    case "W":
                        currentRow--;
                        break;
                    case "S":
                        currentRow++;
                        break;
                    case "A":
                        currentCol--;
                        break;
                    case "D":
                        currentCol++;
                        break;
                }

                if (currentRow >= 0 && currentRow<rowCount && currentCol>=0 && currentCol<matrix[currentRow].Length)
                {
                    if (matrix[currentRow][currentCol] == '-')
                    {
                        matrix[currentRow][currentCol] = 'M';
                    }
                    else if (matrix[currentRow][currentCol] == 'B')
                    {
                        if (lives>2)
                        {
                            lives -= 2;
                            matrix[currentRow][currentCol] = 'M';
                        }
                        else
                        {
                            isDead = true;
                        }
                    }
                    else if (matrix[currentRow][currentCol] == 'P')
                    {
                        matrix[currentRow][currentCol] = '-';
                        matrix[oldRow][oldCol] = '-';
                        lives--;
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                        break;
                    }
                }
                else
                {
                    currentRow = oldRow;
                    currentCol = oldCol;
                }
                matrix[oldRow][oldCol] = '-';
                lives--;
                if (lives<=0||isDead)
                {
                    matrix[currentRow][currentCol] = 'X';
                    Console.WriteLine($"Mario died at {currentRow};{currentCol}.");
                    break;
                }

            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
