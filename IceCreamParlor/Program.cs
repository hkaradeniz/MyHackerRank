using System;

namespace IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());

            for (int k = 0; k < tc; k++)
            {
                int money = int.Parse(Console.ReadLine());
                int flavorCount = int.Parse(Console.ReadLine());

                string[] strArray = Console.ReadLine().Split(' ');
                int[] flavors = Array.ConvertAll(strArray, Int32.Parse);
                bool found = false;

                for (int i = 0; i < flavorCount; i++)
                {
                    for (int j = i + 1; j < flavorCount; j++)
                    {
                        if (flavors[i] + flavors[j] == money)
                        {
                            Console.WriteLine((i + 1) + " " + (j + 1));
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        break;

                }
            }
        }
    }
}
