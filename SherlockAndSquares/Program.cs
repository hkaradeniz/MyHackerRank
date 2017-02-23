using System;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // Number of Test Cases

            for (int i = 0; i < t; i++)
            {
                string[] a_integers = Console.ReadLine().Split(' '); //two space-separated integers denoting A and B
                Int64[] integers = Array.ConvertAll(a_integers, Int64.Parse);

                int result = (int)(Math.Floor(Math.Sqrt(integers[1])) - Math.Ceiling(Math.Sqrt(integers[0])) + 1);

                Console.WriteLine(result);
            }
        }
    }
}
