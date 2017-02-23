using System;
using System.Text;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            // rows×columns≥L
            // ⌊L−−√⌋≤rows≤column≤⌈L−−√⌉
            string s = Console.ReadLine();

            int size = s.Length;
            int rows = (int)Math.Floor(Math.Sqrt(size));
            int cols = (int)Math.Ceiling(Math.Sqrt(size));

            // Ex: chillout
            if (size > rows * cols)
            {
                rows++;
            }

            string[,] matrix = new string[rows, cols];
            int counter = 0;

            // rows×columns≥L
            // ⌊L−−√⌋≤rows≤column≤⌈L−−√⌉

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (counter < size)
                    {
                        matrix[i, j] = s[counter].ToString();
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (!String.IsNullOrEmpty(matrix[j, i]))
                        sb.Append(matrix[j, i]);
                }
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
