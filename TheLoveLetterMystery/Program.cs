using System;

namespace TheLoveLetterMystery
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string str = Console.ReadLine();
                int counter = 0;
                char[] arr = str.ToCharArray();

                //bool isPalindrome = false;

                for (int i = 0; i < str.Length / 2; i++)
                {
                    char head = arr[i];
                    char tail = arr[str.Length - i - 1];

                    while (head != tail)
                    {
                        if (head > tail)
                            head = (char)((int)head - 1);
                        else if (tail > head)
                            tail = (char)((int)tail - 1);
                        else
                            break;

                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}
