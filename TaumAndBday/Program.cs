using System;
using System.Numerics;

namespace TaumAndBday
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_b = Console.ReadLine().Split(' ');
                Int64 b = Convert.ToInt32(tokens_b[0]);
                Int64 w = Convert.ToInt32(tokens_b[1]);
                string[] tokens_x = Console.ReadLine().Split(' ');
                Int64 x = Convert.ToInt32(tokens_x[0]);
                Int64 y = Convert.ToInt32(tokens_x[1]);
                Int64 z = Convert.ToInt32(tokens_x[2]);

                /*
                10 10
                1 1 1
                5 9
                2 3 4
                5∗2 + 9∗3= 10 + 27 = 37
                3 6
                9 1 1
                3∗2 + 6∗1 = 12
                7 7
                4 2 1
                3 3
                1 9 2
                */
                BigInteger totalBill = b * Math.Min(x, y + z) + w * Math.Min(y, x + z);

                Console.WriteLine(totalBill.ToString());

                /*
                Int64 totalBill = 0;

                if(z>=x && z>=y)
                {
                    totalBill = x*b + y*w;    
                }
                else
                {
                    totalBill = Math.Min((b*(y+z) + w*y), (b*x + w*(x+z)));
                }

                Console.WriteLine(totalBill);
                */

            }
        }
    }
}
