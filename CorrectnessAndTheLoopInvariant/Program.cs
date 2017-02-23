using System;
using System.Linq;

namespace CorrectnessAndTheLoopInvariant
{
    class Program
    {
        static void insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i;
                while (j > 0 && value < A[j - 1])
                {
                    A[j] = A[j - 1];
                    A[j - 1] = value;
                    j--;
                }

            }
            Console.WriteLine(string.Join(" ", A));
        }

        static void Main(string[] args)
        {
            // int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9, 0 };
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
        }
    }
}
