using System;

namespace MaximizingXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }

        static int maxXor(int l, int r)
        {
            //2(10) = 1024 => 10 Bits
            string number3 = string.Empty;
            int result = 0;

            for (int i = l; i <= r; i++)
            {
                string number1 = Int_to_Binary(i);

                for (int j = i; j <= r; j++)
                {
                    string number2 = Int_to_Binary(j);

                    for (int k = 0; k < 10; k++)
                    {
                        int xor = number1[k] ^ number2[k];
                        number3 = number3 + xor.ToString();
                    }

                    int temp = Binary_to_Int(number3);
                    //Console.WriteLine(temp);    
                    if (temp > result)
                        result = temp;

                    number3 = string.Empty;
                }
            }

            return result;
        }

        static int Binary_to_Int(string binary)
        {
            int result = 0;
            int subtotal = 1;

            for (int i = 0; i < binary.Length; i++)
            {
                int num = int.Parse(binary[binary.Length - i - 1].ToString());
                result = (num * subtotal) + result;
                subtotal = subtotal * 2;
            }

            return result;
        }

        static string Int_to_Binary(int n)
        {
            char[] b = new char[10];
            int pos = 9;
            int i = 0;

            while (i < 10)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
