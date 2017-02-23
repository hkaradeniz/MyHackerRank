using System;
using System.Text;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[2];
                bool found = false;

                a[0] = n; // stores 5s
                a[1] = 0; // stores 3s

                for (int i = 0; i <= n; i++)
                {
                    int divisibleby3 = a[0] % 3;
                    int divisibleby5 = a[1] % 5;

                    if (divisibleby3 == 0 && divisibleby5 == 0)
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        a[0]--;
                        a[1]++;
                    }
                }


                Console.WriteLine(ReturnLargestNumber(a, found));
            }
        }

        static string ReturnLargestNumber(int[] a, bool found)
        {
            StringBuilder builder = new StringBuilder();

            if (!found)
                return "-1";
            else
            {
                int fives = a[0];
                int threes = a[1];

                for (int i = 0; i < fives; i++)
                    builder.Append("5");

                for (int i = 0; i < threes; i++)
                    builder.Append("3");

                return builder.ToString();
            }
        }
    }
}
