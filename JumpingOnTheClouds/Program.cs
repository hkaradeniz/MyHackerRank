using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int jump = 0;
            int pointer = 0;

            while (pointer < n - 1)
            {
                if (pointer + 2 < n && c[pointer + 2] == 0)
                    pointer = pointer + 2;
                else
                    pointer++;

                jump++;
            }

            Console.WriteLine(jump);
        }
    }
}
