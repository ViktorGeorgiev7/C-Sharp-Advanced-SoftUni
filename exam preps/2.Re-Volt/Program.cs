using System;

namespace _2.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            FillMatrix(matrix);

            while (true)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col] == 'f')
                        {
                            switch (Console.ReadLine())
                            {
                                case "up":
                                    if (row==0)
                                    {
                                        
                                    }
                                    break;
                                case "down":
                                    break;
                                case "right":
                                    break;
                                case "left":
                                    break;
                            }   
                        }
                    }
                }
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
