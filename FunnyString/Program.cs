using System;

namespace FunnyString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();
                int head = 0;
                int tail = str.Length - 1;
                bool funny = true;

                while (head != str.Length - 1)
                {
                    int dif1 = Math.Abs((int)str[head] - (int)str[head + 1]);
                    int dif2 = Math.Abs((int)str[tail] - (int)str[tail - 1]);

                    if (dif1 != dif2)
                    {
                        funny = false;
                        break;
                    }
                    head++;
                    tail--;
                }

                if (funny)
                    Console.WriteLine("Funny");
                else
                    Console.WriteLine("Not Funny");

            }
        }
    }
}
