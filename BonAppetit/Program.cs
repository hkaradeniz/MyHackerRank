using System;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int totalOrder = Convert.ToInt32(tokens_x1[0]);
            int annaSkipped = Convert.ToInt32(tokens_x1[1]);

            Int32[] prices = new Int32[totalOrder];

            string[] tokens_x2 = Console.ReadLine().Split(' ');
            int total = 0;

            for (int i = 0; i < totalOrder; i++)
            {
                prices[i] = Convert.ToInt32(tokens_x2[i]);
                total += prices[i];
            }

            //Console.WriteLine(total);

            Int32 annaPaid = Convert.ToInt32(Console.ReadLine());

            int annaMustPay = (total - prices[annaSkipped]) / 2;

            if (annaMustPay == annaPaid)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(annaPaid - annaMustPay);
            }
        }
    }
}
