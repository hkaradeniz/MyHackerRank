using System;

namespace RunningTimeOfAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            a = Array.ConvertAll(a_temp, Int32.Parse);

            int j, element;
            int counter = 0;

            for (int i = 1; i < n; i++)
            {
                element = a[i];
                j = i;

                while (j > 0 && a[j - 1] > element)
                {
                    a[j] = a[j - 1];
                    a[j - 1] = element;
                    j--;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
