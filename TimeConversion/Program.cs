using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            string meridiem = time.Substring(time.Length - 2);
            string strHour = time.Substring(0, 2);
            string minsseconds = time.Substring(2, time.Length - 4);
            int inthour = int.Parse(strHour);
            inthour = inthour % 12;
            string new_time = "";

            if (meridiem == "PM")
            {
                inthour += 12;
            }
            else
            {
                new_time = time.Replace("AM", "");
            }

            new_time = inthour.ToString("00") + minsseconds;

            Console.Write(new_time);
        }
    }
}
