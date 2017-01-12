using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = Convert.ToInt32(Console.ReadLine());
            //string[] strArray = Console.ReadLine().Split(' ');
            //int numberOfTestCases = 5;
            //string[] strArray = "AAAA BBBBB ABABABAB BABABA AAABBB".ToString().Split(' ');

            char previousChar = ' ';
            int count = 0;

            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();
                char[] charArray = str.ToCharArray();

                foreach (char character in charArray)
                {
                    if (previousChar == character)
                    {
                        count++;
                    }

                    previousChar = character;
                }

                Console.WriteLine("{0}", count);
                count = 0;
                previousChar = ' ';
            }
        }
    }
}
