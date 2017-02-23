using System;
using System.Collections.Generic;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }
            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }

        static int lonelyinteger(int[] a)
        {

            Dictionary<int, int> li = new Dictionary<int, int>();

            foreach (int integer in a)
            {
                if (li.ContainsKey(integer))
                {
                    li[integer]++;
                }
                else
                {
                    li.Add(integer, 1);
                }
            }

            foreach (var pair in li)
            {
                int number = pair.Value % 2;
                if (number > 0)
                {
                    return pair.Key;
                }
            }
            return 0;
        }
    }
}
