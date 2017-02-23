using System;

namespace PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string str = Console.ReadLine();
                int head = 0;
                int tail = str.Length - 1;

                while (head < tail)
                {
                    if (str[head] == str[tail])
                    {
                        head++;
                        tail--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (head >= tail)
                {
                    Console.WriteLine("-1");
                }
                else if (str[head + 1] == str[tail])
                {
                    if (str[head] == str[tail - 1])
                    {
                        if (str[head + 2] == str[tail - 3])
                        {
                            Console.WriteLine(tail);
                        }
                        else
                        {
                            Console.WriteLine(head);
                        }
                    }
                    else
                    {
                        Console.WriteLine(head);
                    }
                }
                else
                {
                    Console.WriteLine(tail);
                }
            }
        }
    }
}
