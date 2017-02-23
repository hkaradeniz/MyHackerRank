using System;
using System.Collections.Generic;

namespace Gemstones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRocks = Int32.Parse(Console.ReadLine());
            int totalGems = 0;
            string[] rocksArray = new string[numberOfRocks];

            for (int i = 0; i < numberOfRocks; i++)
            {
                rocksArray[i] = Console.ReadLine();
            }

            Dictionary<char, int> dict = new Dictionary<char, int>(); // if int count more than/equal to numberOfRocks we are good
            HashSet<char> tempHash = new HashSet<char>(); // to avoid same multiple elements in one rock

            for (int i = 0; i < rocksArray.Length; i++)
            {
                char[] charArray = rocksArray[i].ToCharArray();
                tempHash.Clear();

                foreach (var item in charArray)
                {
                    if (!tempHash.Contains(item))
                    {
                        if (dict.ContainsKey(item))
                        {
                            dict[item]++;

                            if (dict[item] >= numberOfRocks)
                            {
                                totalGems++;
                            }
                        }
                        else
                        {
                            dict.Add(item, 1);
                        }

                        tempHash.Add(item);
                    }
                }
            }

            Console.WriteLine(totalGems);
        }
    }
}
