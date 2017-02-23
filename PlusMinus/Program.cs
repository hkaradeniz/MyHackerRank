using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            if (n > 0)
            {
                decimal zeros = 0;
                decimal positives = 0;
                decimal negatives = 0;

                foreach (int num in arr)
                {
                    if (num == 0)
                        zeros++;
                    else if (num < 0)
                        negatives++;
                    else
                        positives++;
                }

                decimal decZeros = 0;
                decimal decPositives = 0;
                decimal decNegatives = 0;

                if (zeros != 0)
                    decZeros = zeros / n;
                if (positives != 0)
                    decPositives = positives / n;
                if (negatives != 0)
                    decNegatives = negatives / n;

                Console.WriteLine(decPositives.ToString("0.######"));
                Console.WriteLine(decNegatives.ToString("0.######"));
                Console.WriteLine(decZeros.ToString("0.######"));
            }
            else
            {
                Console.WriteLine("0.000000");
                Console.WriteLine("0.000000");
                Console.WriteLine("0.000000");
            }
        }
    }
}
