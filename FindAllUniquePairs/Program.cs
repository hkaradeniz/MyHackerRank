﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllUniquePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* AMAZON INTERVIEW
               Given an array of integers and a target integer, find all unique pairs of 
               integers that add up to the target integer.

               Example: [1, 2, 3, 4, 6] and target 6
               Expected output: [2, 4]
               Actual output: [[2, 4], [3, 3]]

               Example: [1, 2, 3, 5, 7, 8, 9, 11] and target 12 <----
               Expected output: [[1, 11], [3, 9], [5, 7]]
               Actual output: [[1, 11], [3, 9], [5, 7]]
            */

            int[] array = { 1, 2, 3, 5, 7, 8, 9, 11 };
            int lenght = array.Length;
            int target = 6;

            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < lenght; i++)
            {
                int temp = target - array[i];

                if (hashSet.Contains(temp))
                {
                    Console.WriteLine("{0}, {1}", array[i].ToString(), temp.ToString());
                }
                hashSet.Add(array[i]);
            }
        }
    }
}
