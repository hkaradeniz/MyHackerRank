using System;

namespace RichieRich
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NOT WORKING
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string number = Console.ReadLine();

            //bool changeable=true;

            int head = 0;
            int tail = number.Length - 1;
            int counter = 0;
            char[] arr = number.ToCharArray();

            while (head < tail)
            {
                if (arr[head] != arr[tail])
                {
                    counter++;
                }

                head++;
                tail--;

                if (counter > k)
                {
                    Console.WriteLine("-1");
                    return;
                }
            }

            head = 0;
            tail = number.Length - 1;
            int available9s = k - counter;

            while (head < tail)
            {
                if (available9s > 0)
                {
                    if (arr[head] != '9')
                    {
                        arr[head] = '9';
                        available9s--;
                    }

                    if (arr[tail] != '9')
                    {
                        arr[tail] = '9';
                        available9s--;
                    }
                }
                else
                {
                    if (arr[head] != arr[tail])
                    {
                        if (arr[tail] > arr[head])
                            arr[head] = arr[tail];
                        else
                            arr[tail] = arr[head];
                    }
                }

                head++;
                tail--;
            }

            Console.WriteLine(new string(arr));
            #endregion
        }
    }
}
