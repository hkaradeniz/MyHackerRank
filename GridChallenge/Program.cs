using System;

namespace GridChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());

            while (tc != 0)
            {
                int n = int.Parse(Console.ReadLine());
                char[,] arr = new char[n, n];
                bool lexicographical = true;
                //Console.WriteLine("-->"+ n);

                for (int i = 0; i < n; i++)
                {
                    string row = Console.ReadLine();
                    //Console.WriteLine("-->"+ row);
                    string sortedRow = SortStr(row);

                    for (int j = 0; j < n; j++)
                    {
                        //Console.WriteLine("-->"+ row[j]);
                        arr[i, j] = sortedRow[j];
                    }
                }

                for (int j = 0; j < n && lexicographical; j++)
                {
                    for (int k = 1; k < n && lexicographical; k++)
                    {
                        if (arr[k, j] < arr[k - 1, j])
                            lexicographical = false;
                    }
                }

                Console.WriteLine(lexicographical ? "YES" : "NO");

                tc--;
            }
        }

        static string SortStr(string str)
        {
            int arraySize = str.Length;
            int j; char element;
            char[] ar = new char[arraySize];
            ar = str.ToCharArray();

            for (int i = 1; i < arraySize; i++)
            {
                element = str[i];
                j = i;
                while (j > 0 && ar[j - 1] > element)
                {
                    ar[j] = ar[j - 1];
                    ar[j - 1] = element;
                    j--;
                }
            }

            return new String(ar);
        }
    }
}
