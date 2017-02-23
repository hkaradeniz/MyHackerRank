using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    for (int space = 1; space < n - i + 1; space++)
                        Console.Write(" ");
                    for (int star = n - i + 1; star < n + 1; star++)
                        Console.Write("#");

                    Console.WriteLine();
                }
            }
        }
    }
}
