using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            // Array a
            // Matrix NxN 3x3
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                firstDiagonal = firstDiagonal + a[i][i];
                secondDiagonal = secondDiagonal + a[i][n - i - 1];
            }

            int total = firstDiagonal - secondDiagonal;

            if (total < 0)
                total = total * (-1);

            Console.WriteLine(total);
        }
    }
}
