using System;

namespace PermutingTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int tc = int.Parse(Console.ReadLine());
            while (tc != 0)
            {
                string[] nk = Console.ReadLine().Split(' ');
                int n = int.Parse(nk[0]);
                int k = int.Parse(nk[1]);
                bool pair = true;

                int[] a1 = new int[n];
                string[] a_temp1 = Console.ReadLine().Split(' ');
                a1 = Array.ConvertAll(a_temp1, Int32.Parse);

                int[] a2 = new int[n];
                string[] a_temp2 = Console.ReadLine().Split(' ');
                a2 = Array.ConvertAll(a_temp2, Int32.Parse);

                Array.Sort(a1);
                Array.Sort(a2);

                for (int i = 0; i < n; i++)
                {
                    if (a1[i] + a2[n - i - 1] < k)
                    {
                        pair = false;
                        break;
                    }
                }

                if (pair)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                tc--;
            }
        }
    }
}
