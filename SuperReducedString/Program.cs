using System;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string str = Console.ReadLine();
            int pointer = 0;

            while (pointer < str.Length - 1)
            {
                if (str[pointer] == str[pointer + 1])
                {
                    str = str.Remove(pointer, 2);

                    if (pointer > 0)
                        pointer--;
                }
                else
                {
                    pointer++;
                }
            }

            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Empty String");
            else
                Console.WriteLine(str);
        }
    }
}
