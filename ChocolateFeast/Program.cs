using System;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int c = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int totalChocolate = n / c;
                int totalWrapper = totalChocolate;
                int newChocolate = 0;
                int leftWrapper = 0;

                //6 2 2
                // totalChocolate:3
                // totalWrapper:3
                while (totalWrapper >= m)
                {
                    newChocolate = totalWrapper / m; // newChocolate:1 totalWrapper:3
                    totalChocolate += newChocolate;  // totalChocolate:4
                    leftWrapper = totalWrapper % m;  // leftWrapper: 1 totalWrapper:3
                    totalWrapper = newChocolate + leftWrapper;
                }

                Console.WriteLine(totalChocolate);
            }
    }
}
