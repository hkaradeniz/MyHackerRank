using System;

namespace StockMaximize
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            /*
            3 : Number of Test Cases
                3 : Next Three Days
                    5 3 2
                3 : Next Three Days
                    1 2 100
                4 : Next Four Days
                    1 3 1 2
            */
            // http://aruncyberspace.blogspot.com/2014/09/algorithms-dynamic-programming-stock.html

            int numOfTestCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCase; i++)
            {
                int totalDays = int.Parse(Console.ReadLine());
                Int64 profit = 0;

                string predictedPrice = Console.ReadLine();
                string[] predictedPrices = predictedPrice.Split(' ');

                Int64[] stockPrice = new Int64[totalDays];

                for (int j = 0; j < totalDays; j++)
                {
                    Int64 num1;
                    bool res = Int64.TryParse(predictedPrices[j], out num1);
                    if (res == true)
                    {
                        stockPrice[j] = num1;
                    }
                }

                //  5 3 2 => 0
                //  1 2 100 => 197
                //  1 3 1 2 => 3
                Int64 maxValue = 0;

                for (int j = totalDays - 1; j >= 0; j--)
                {
                    if (maxValue < stockPrice[j])
                    {
                        maxValue = stockPrice[j];
                    }

                    profit += (maxValue - stockPrice[j]);

                }
                Console.WriteLine(profit);
            }
        }
    }
}
