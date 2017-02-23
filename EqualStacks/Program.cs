using System;
using System.Linq;

namespace EqualStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n1 = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(tokens_n1[0]); // Number of cylinders 1
            int n2 = Convert.ToInt32(tokens_n1[1]); // Number of cylinders 2
            int n3 = Convert.ToInt32(tokens_n1[2]); // Number of cylinders 3
            string[] h1_temp = Console.ReadLine().Split(' ');
            int[] h1 = Array.ConvertAll(h1_temp, Int32.Parse); // Array 1
            string[] h2_temp = Console.ReadLine().Split(' ');
            int[] h2 = Array.ConvertAll(h2_temp, Int32.Parse); // Array 2
            string[] h3_temp = Console.ReadLine().Split(' ');
            int[] h3 = Array.ConvertAll(h3_temp, Int32.Parse); // Array 3

            int sum1 = h1.Sum();
            int sum2 = h2.Sum();
            int sum3 = h3.Sum();

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;

            while (true)
            {
                while (sum2 > sum1)
                {
                    sum2 = sum2 - h2[counter2];
                    counter2++;
                }

                while (sum3 > sum1)
                {
                    sum3 = sum3 - h3[counter3];
                    counter3++;
                }

                if (sum1 == sum2 && sum1 == sum3)
                    break;
                else
                    sum1 = sum1 - h1[counter1];
                counter1++;

            }

            Console.WriteLine(sum1);
        }
    }
}
