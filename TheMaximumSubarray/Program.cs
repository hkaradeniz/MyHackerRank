using System;

namespace TheMaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int tc = int.Parse(Console.ReadLine());

            for (int k = 0; k < tc; k++)
            {
                int size = int.Parse(Console.ReadLine());
                string[] strArray = Console.ReadLine().Split(' ');
                int[] numbers = Array.ConvertAll(strArray, Int32.Parse);

                int noncontiguousMax = 0;
                int maxNum = Int32.MinValue;
                int arrayTotal = 0;

                for (int i = 0; i < size; i++)
                {
                    // This is if all the numbers in array are negatives...
                    if (numbers[i] > maxNum)
                    {
                        maxNum = numbers[i];
                    }

                    if (numbers[i] > 0)
                    {
                        noncontiguousMax += numbers[i];
                    }

                    arrayTotal += numbers[i];
                }

                // This means there is no positive number in the array... So assign the biggest number
                if (noncontiguousMax == 0)
                {
                    noncontiguousMax = maxNum;
                }

                //Kadane's algorithm
                int contiguousMax = numbers[0];
                int currMax = numbers[0];

                for (int i = 1; i < size; i++)
                {
                    currMax = Math.Max(numbers[i], currMax + numbers[i]);
                    contiguousMax = Math.Max(contiguousMax, currMax);
                }


                Console.WriteLine("{0} {1}", contiguousMax, noncontiguousMax);
            }
        }
    }
}
