using System;
using System.Collections.Generic;

namespace StringConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string s = Console.ReadLine();

                var hash = new HashSet<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (!hash.Contains(c))
                        hash.Add(c);
                }

                Console.WriteLine(hash.Count);
                hash.Clear();
            }
        }
    }
}
