using System;

namespace CompareTheTriplets
{
    class Program
    {
        static int aliceScore = 0;
        static int bobScore = 0;

        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            // Use CompareTo 
            /*
            int a = 5;
            int b = 6;
            int c = 5;
            int ab = a.CompareTo(b);
            int ba = b.CompareTo(a);
            int ca = c.CompareTo(a);
            -1
             1
             0
             $"({aliceScore} {bobScore})";
            */

            CompareGrades(a0, b0);
            CompareGrades(a1, b1);
            CompareGrades(a2, b2);
            Console.WriteLine("{0} {1}", aliceScore, bobScore);
        }

        static void CompareGrades(int a, int b)
        {
            if (a.CompareTo(b) < 0)
                bobScore++;
            else if (a.CompareTo(b) > 0)
                aliceScore++;
        }
    }
}
