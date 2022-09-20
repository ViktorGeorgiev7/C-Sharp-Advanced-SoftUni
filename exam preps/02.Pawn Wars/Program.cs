using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;

namespace _02.Pawn_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] chessboard = new char[8, 8];
            for (int r = 0; r < 8; r++)
            {
                string input = Console.ReadLine();
                for (int c = 0; c < 8; c++)
                {
                    chessboard[r, c] = input![c];
                }
            }
            int[] whiteCoordinates = {0,0};
            int[] blackCoordinates = {0,0};
            FindCoordinates(chessboard, blackCoordinates, whiteCoordinates);
            bool colision = whiteCoordinates[1]-1==blackCoordinates[1] || whiteCoordinates[1]+1==blackCoordinates[1] && whiteCoordinates[0] > blackCoordinates[0];
            if (colision)
            {
                while (true)
                {
                    int count = 1;
                    if (count % 2 == 0)//black
                    {
                        count++;
                    }
                    else//white
                    {
                        count++;
                    }
                }
            }
            else
            {//check rows
                for (int row = 0; row < chessboard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessboard.GetLength(1); col++)
                    {
                        chessboard[whiteCoordinates[0], whiteCoordinates[1]] = 
                    }
                }
            }

        }

        public static void FindCoordinates(char[,] matrix,int[] black,int[] white)
        {
            
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows,cols] == 'b')
                    {
                        black[0] = rows;
                        black[1] = cols;
                    }
                    else if (matrix[rows, cols] == 'w')
                    {
                        white[0] = rows;
                        white[1] = cols;
                    }
                }
            }

        }
    }
}
