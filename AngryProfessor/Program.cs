using System;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                int offTimeArrival = 0;
                bool isCanceled = false;

                foreach (var arrivalTime in a)
                {
                    if (arrivalTime > 0)
                    {
                        offTimeArrival++;
                        if (offTimeArrival > n - k)
                        {
                            isCanceled = true;
                            break;
                        }
                    }
                }

                if (isCanceled)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            // t=> Number of Test Cases 1≤T≤10
            // n=> students in the class 1≤N≤1000
            // k=> the cancelation threshold 1≤K≤N
            // a[] => the arrival times for each student (n). −100≤ai≤100
            // - student arrived early or on time
            // + student arrived + mins late
            // For each test case, print the word YES if the class is canceled or NO if it is not.
        }
    }
}
