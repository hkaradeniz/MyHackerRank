using System;

namespace CaesarCipher
{
    class Program
    {
        //static int LowerCaseMin = 97;
        //static int LowerCaseMax = 122;
        //static int UpperCaseMin = 65;
        //static int UpperCaseMax = 90;

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // The first line contains an integer, N, which is the length of the unencrypted string. 
            string s = Console.ReadLine(); // The second line contains the unencrypted string, S. 
            int k = Convert.ToInt32(Console.ReadLine()); // The third line contains the integer encryption key, K, which is the number of letters to rotate.

            for (int i = 0; i < n; i++)
            {
                Console.Write(((char)Numerator(((int)s[i]), k)).ToString());
            }
        }

        static int Numerator(int val, int increment)
        {
            if (val > 96 && val < 123)
            {
                for (int i = 1; i <= increment; i++)
                {
                    val++;
                    if (val == 123)
                        val = 97;
                }
            }
            else if (val > 64 && val < 91)
            {
                for (int i = 1; i <= increment; i++)
                {
                    val++;
                    if (val == 91)
                        val = 65;
                }
            }

            return val;
        }
    }
}
