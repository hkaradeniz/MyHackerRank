using System;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 min = 0;
            Int64 max = 0;

            string[] strArray = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(strArray, Int32.Parse);
            int[] sortedArray = MergeSort(array, 0, array.Length - 1);

            for (int i = 0; i < 4; i++)
            {
                min = min + sortedArray[i];
                max = max + sortedArray[sortedArray.Length - 1 - i];
            }

            Console.WriteLine("{0} {1}", min, max);
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
