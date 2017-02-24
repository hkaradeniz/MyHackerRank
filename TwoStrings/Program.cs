using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int tc = int.Parse(Console.ReadLine());

            while (tc != 0)
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                bool substringAppears = false;

                HashSet<char> h = new HashSet<char>();

                for (int j = 0; j < str1.Length; j++)
                {
                    h.Add(str1[j]);
                }

                for (int k = 0; k < str2.Length; k++)
                {
                    if (h.Contains(str2[k]))
                    {
                        substringAppears = true;
                        break;
                    }
                }

                if (substringAppears)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                tc--;
            }
        }
    }
}
