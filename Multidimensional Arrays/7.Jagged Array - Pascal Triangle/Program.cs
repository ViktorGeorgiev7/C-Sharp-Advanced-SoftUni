using System;
using System.Numerics;

namespace _7.Jagged_Array___Pascal_Triangle
{
    class Program
    {
 
    class GFG
    {

        // Function to print first
        // n lines of Pascal's Triangle
        static void printPascal(BigInteger n)
        {

            // Iterate through every line
            // and print entries in it
            for (int line = 0; line < n; line++)
            {
                // Every line has number of
                // integers equal to line number
                for (int i = 0; i <= line; i++)
                    Console.Write(BinomialCoeff
                        (line, i) + " ");

                Console.WriteLine();
            }
        }
        static BigInteger BinomialCoeff(int n, int k)
        {
            BigInteger res = 1;

            if (k > n - k)
                k = n - k;

            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }
            return res;
        }

        // Driver code
        public static void Main()
        {
            BigInteger n = int.Parse(Console.ReadLine());
            printPascal(n);
            
            
        }
    }
}
}
