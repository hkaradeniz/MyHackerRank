using System;
using System.Collections.Generic;

namespace TheTimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, string> minutes = new Dictionary<int, string>();
            Dictionary<int, string> hours = new Dictionary<int, string>();

            minutes.Add(1, "one minute");
            minutes.Add(2, "two minutes");
            minutes.Add(3, "three minutes");
            minutes.Add(4, "four minutes");
            minutes.Add(5, "five minutes");
            minutes.Add(6, "six minutes");
            minutes.Add(7, "seven minutes");
            minutes.Add(8, "eight minutes");
            minutes.Add(9, "nine minutes");
            minutes.Add(10, "ten minutes");
            minutes.Add(11, "eleven minutes");
            minutes.Add(12, "twelve minutes");
            minutes.Add(13, "thirteen minutes");
            minutes.Add(14, "fourteen minutes");
            minutes.Add(15, "quarter");
            minutes.Add(16, "sixteen minutes");
            minutes.Add(17, "seventeen minutes");
            minutes.Add(18, "eighteen minutes");
            minutes.Add(19, "nineteen minutes");
            minutes.Add(20, "twenty minutes");
            minutes.Add(21, "twenty one minutes");
            minutes.Add(22, "twenty two minutes");
            minutes.Add(23, "twenty three minutes");
            minutes.Add(24, "twenty four minutes");
            minutes.Add(25, "twenty five minutes");
            minutes.Add(26, "twenty six minutes");
            minutes.Add(27, "twenty seven minutes");
            minutes.Add(28, "twenty eight minutes");
            minutes.Add(29, "twenty nine minutes");
            minutes.Add(30, "half");

            hours.Add(1, "one");
            hours.Add(2, "two");
            hours.Add(3, "three");
            hours.Add(4, "four");
            hours.Add(5, "five");
            hours.Add(6, "six");
            hours.Add(7, "seven");
            hours.Add(8, "eight");
            hours.Add(9, "nine");
            hours.Add(10, "ten");
            hours.Add(11, "eleven");
            hours.Add(12, "twelve");

            /*
             5:47 thirteen minutes to six
            */
            if (m == 0)
            {
                Console.WriteLine(hours[h] + " o' clock");
            }
            else if (m <= 30)
            {
                Console.WriteLine(minutes[m] + " past " + hours[h]);
            }
            else
            {
                Console.WriteLine(minutes[60 - m] + " to " + hours[h + 1]);
            }
        }
    }
}
