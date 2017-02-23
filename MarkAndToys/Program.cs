using System;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int numberOfToys = int.Parse(nk[0]);
            int totalMoney = int.Parse(nk[1]);

            int[] prices = new int[numberOfToys];
            string[] pricesStr = Console.ReadLine().Split(' ');
            prices = Array.ConvertAll(pricesStr, Int32.Parse);

            prices = MergeSort(prices, 0, numberOfToys - 1);
            int counter = 0;
            int total = 0;

            foreach (var item in prices)
            {
                total += item;
                if (total <= totalMoney)
                    counter++;
                else
                    break;
            }

            Console.WriteLine(counter);
        }

        static int[] MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }

            return input;
        }
    }
}
