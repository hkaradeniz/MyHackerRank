using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            bool met = false;

            // 0 2 5 3
            // 0 3 4 2
            if (v2 < v1)
            {
                if ((x1 - x2) % (v2 - v1) == 0)
                {
                    met = true;
                }
            }

            if (met)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
