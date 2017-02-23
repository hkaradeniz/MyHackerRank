using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialIterative(10);
            FactorialRecursive(10);
            Console.ReadLine();
        }

        static int FactorialIterative(int num)
        {
            int prod = 1;

            for (int i = num; i > 0; --i)
            {
                prod *= (i);
            }

            return prod;
        }

        static int FactorialRecursive(int num)
        {
            return num == 0 ? 1 : num * FactorialRecursive(num - 1);
        }
    }
}
