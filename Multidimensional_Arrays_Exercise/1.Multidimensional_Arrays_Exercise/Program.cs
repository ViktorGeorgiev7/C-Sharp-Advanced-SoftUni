using System;
using System.Linq;

namespace _1.Multidimensional_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int nxn = int.Parse(Console.ReadLine());
            int[,] matrix = new int[nxn, nxn];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] rowsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                }
            }
            //dia
            int diagonalPosition = 0;
            int primeSum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    primeSum += matrix[diagonalPosition, cols];
                    diagonalPosition++;
                }

                break;

            }

            int reversePosition = nxn;
            int reverseSum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    reverseSum += matrix[reversePosition-1, cols];
                    reversePosition--;
                }

                break;
            }

            if (primeSum-reverseSum < 0)
            {
                Console.WriteLine((primeSum - reverseSum)*(-1));
            }
            else
            {
                Console.WriteLine(primeSum-reverseSum);
            }
        }
    }
}
