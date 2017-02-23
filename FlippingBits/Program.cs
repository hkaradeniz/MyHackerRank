using System;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 size = Convert.ToInt32(Console.ReadLine());
            Int64[] flipArray = new Int64[size];

            for (int i = 0; i < size; i++)
            {
                flipArray[i] = Convert.ToInt64(Console.ReadLine());
            }

            foreach (int num in flipArray)
            {
                Console.WriteLine(Binary_to_Int(Int_to_Binary_Flip(num)));
            }
        }

        static Int64 Binary_to_Int(string binary)
        {
            Int64 result = 0;
            Int64 subtotal = 1;

            for (int i = 0; i < binary.Length; i++)
            {
                string c = binary[binary.Length - i - 1].ToString();
                int num = c == "1" ? 0 : 1;
                result = (num * subtotal) + result;
                subtotal = subtotal * 2;
            }

            return result;
        }

        static string Int_to_Binary_Flip(Int64 n)
        {
            /*
                char[] b = new char[32];
                int pos = 31;
                int i = 0;

                while (i < 32)
                {
                    if ((n & (1 << i)) != 0)
                    {
                        b[pos] = '0'; // flip
                    }
                    else
                    {
                        b[pos] = '1'; // flip
                    }
                    pos--;
                    i++;
                }
                return new string(b);
            */
            var result = Convert.ToString(n, 2);
            result = result.PadLeft(32, '0');
            return result;
        }
    }
}
