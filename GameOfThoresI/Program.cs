using System;
using System.Collections.Generic;

namespace GameOfThoresI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string stdin = Console.ReadLine();

            char[] array = stdin.ToLower().ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char character in array)
            {
                if (dict.ContainsKey(character))
                {
                    dict[character]++;
                }
                else
                {
                    dict[character] = 1;
                }
            }

            int counter = 0;
            foreach (var pair in dict)
            {
                int result = pair.Value % 2;

                if (result > 0)
                    counter++;

                if (counter > 1)
                {
                    Console.Write("NO");
                    return;
                }
            }

            Console.Write("YES");
        }
    }
}
