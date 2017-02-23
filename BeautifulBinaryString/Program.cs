using System;
using System.Text;

namespace BeautifulBinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();
            StringBuilder sb = new StringBuilder(B);
            int count = 0;

            // 0100101010
            for (int i = 0; i < n - 2; i++)
            {
                string str = sb.ToString(i, 3);
                if (str == "010")
                {
                    //B[i+2] = 1;
                    sb[i + 2] = '1';
                    count++;
                    i += 2;
                }
            }

            Console.WriteLine(count);
        }
    }
}
