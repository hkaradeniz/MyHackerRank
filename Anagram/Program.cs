using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int tc = int.Parse(Console.ReadLine());
            int counter;

            while (tc != 0)
            {
                counter = 0;

                string text = Console.ReadLine();
                int middle = text.Length / 2;

                string t1 = text.Substring(0, middle);
                string t2 = text.Substring(middle);

                //   Console.WriteLine("1: {0} ** 2: {1}",t1,t2);
                if (t1.Length != t2.Length)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Dictionary<char, int> d1 = new Dictionary<char, int>();
                    Dictionary<char, int> d2 = new Dictionary<char, int>();

                    for (int i = 0; i < t1.Length; i++)
                    {
                        if (d1.ContainsKey(t1[i]))
                            d1[t1[i]]++;
                        else
                            d1[t1[i]] = 1;

                        if (d2.ContainsKey(t2[i]))
                            d2[t2[i]]++;
                        else
                            d2[t2[i]] = 1;
                    }

                    //   xy yx
                    //   xaxb bbxx
                    foreach (var item in d1)
                    {
                        char c = item.Key;

                        if (d2.ContainsKey(c))
                            counter += Math.Abs(d1[c] - d2[c]);
                        else
                            counter += d1[c];
                    }

                    foreach (var item in d2)
                    {
                        char c = item.Key;

                        if (!d1.ContainsKey(c))
                            counter += d2[c];
                    }

                    counter = counter / 2;

                    Console.WriteLine(counter);
                }

                tc--;
            }
        }
    }
}
