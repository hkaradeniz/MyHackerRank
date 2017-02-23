using System;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            //1 3 2 6 1 2
            int counter = 0;
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if ((a[i] + a[j]) % k == 0)
                        counter++;

            Console.WriteLine(counter);
        }
    }
}
