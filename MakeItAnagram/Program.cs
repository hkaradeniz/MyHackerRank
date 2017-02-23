using System;
using System.Collections.Generic;

namespace MakeItAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "cde";
            //string str2 = "abc";
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int totalDifference = 0;

            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                if (dict1.ContainsKey(str1[i]))
                {
                    dict1[str1[i]]++;
                }
                else
                {
                    dict1.Add(str1[i], 1);
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (dict2.ContainsKey(str2[i]))
                {
                    dict2[str2[i]]++;
                }
                else
                {
                    dict2.Add(str2[i], 1);
                }
            }

            foreach (var item in dict1)
            {
                if (dict2.ContainsKey(item.Key))
                {
                    int difference = Math.Abs(item.Value - dict2[item.Key]);
                    totalDifference += difference;
                    dict2.Remove(item.Key);
                }
                else
                {
                    totalDifference += item.Value;
                }
            }

            foreach (var item in dict2)
            {
                totalDifference += item.Value;
            }


            Console.WriteLine(totalDifference);
        }
    }
    
}
