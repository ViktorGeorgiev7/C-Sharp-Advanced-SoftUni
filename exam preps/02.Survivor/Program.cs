using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            FillMatrix(matrix);
            int myTokens = 0;
            int opponentTokens = 0;
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Gong")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                switch (input[0])
                {
                    case "Find":
                        if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                        {
                            if (matrix[row][col] == 'T')
                            {
                                myTokens++;
                                matrix[row][col] = '-';
                            }
                        }
                        break;
                    case "Opponent":
                        if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                        {
                            if (matrix[row][col] == 'T')
                            {
                                opponentTokens++;//if he lands on a token with coordinates
                                matrix[row][col] = '-';
                                for (int i = 0; i < 3; i++)
                                {
                                    switch (input[3])
                                    {
                                        case "up":
                                            row--;
                                            break;
                                        case "down":
                                            row++;
                                            break;
                                        case "left":
                                            col--;
                                            break;
                                        case "right":
                                            col++;
                                            break;
                                    }

                                    if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                                    {
                                        if (matrix[row][col] == 'T')
                                        {//if he lands on token while 3 steps
                                            opponentTokens++;
                                            matrix[row][col] = '-';
                                        }
                                    }
                                    else
                                    {//outside of field
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            PrintMatrix(matrix);
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
        private static void FillMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[row] = input;
            }
        }
        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
