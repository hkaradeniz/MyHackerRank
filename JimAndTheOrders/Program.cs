using System;

namespace JimAndTheOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            Order[] ar = new Order[orders];

            for (int i = 0; i < orders; i++)
            {
                string[] times = Console.ReadLine().Split(' ');
                Order order = new Order();
                order.oTime = int.Parse(times[0]);
                order.pTime = int.Parse(times[1]);
                order.Sequence = i + 1;
                ar[i] = order;
            }

            Sort(ar);
        }

        static void Sort(Order[] ar)
        {
            int arraySize = ar.Length;
            int j;
            Order element;

            for (int i = 1; i < arraySize; i++)
            {
                element = ar[i];
                j = i;
                while (j > 0 && ar[j - 1].TotalTime() > element.TotalTime())
                {
                    ar[j] = ar[j - 1];
                    ar[j - 1] = element;
                    j--;
                }
            }

            foreach (var item in ar)
            {
                Console.Write(item.Sequence + " ");
            }
        }
    }
}
