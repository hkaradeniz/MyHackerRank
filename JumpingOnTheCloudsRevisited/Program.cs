using System;

namespace JumpingOnTheCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int thundercloud = 0;

            // 9 3
            // 0 0 1 0 0 1 1 0 0
            // 92
            for (int i = 0; i < n; i += k)
            {
                thundercloud += c[i];
            }

            Console.WriteLine(100 - (thundercloud * 2) - n / k);
        }
    }
}
