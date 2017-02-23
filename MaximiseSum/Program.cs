using System;

namespace MaximiseSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray1 = "5 7".Split(' ');
            int n = int.Parse(strArray1[0]);
            int m = int.Parse(strArray1[1]);

            string[] strArray2 = "3 3 9 9 5".Split(' ');
            int[] numbers = Array.ConvertAll(strArray2, Int32.Parse);

            //int count = numbers.Length;
            int result = 0;
            int head = 0;
            int tail = n;
            //int pointer = 0;

            while (head < tail)
            {
                for (int i = 0; i < tail - head; i++)
                {
                    int temp = SubArrayTotal(numbers, head, i);
                    int mode = temp % m;

                    if (mode < m && mode > result)
                        result = mode;
                }

                head++;
            }

            Console.WriteLine(result);
        }

        static int SubArrayTotal(int[] a, int start, int end)
        {
            int total = 0;
            int counter = 0;
            while (counter != end + 1)
            {
                total += a[start];
                start++;
                counter++;
            }

            //3 3 9 9 5
            //for (int i = start; i < end; i++)
            //{
            //    total += a[i];
            //}
            //while (start <= end)
            //{
            //    total += a[start];
            //    start++;
            //}

            return total;
        }
    }
}
