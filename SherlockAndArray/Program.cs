using System;

namespace SherlockAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());

            while (tc != 0)
            {
                int size = int.Parse(Console.ReadLine());
                string[] strArray = Console.ReadLine().Split(' ');
                int[] numbers = Array.ConvertAll(strArray, Int32.Parse);

                int left = 0;
                int total = 0;
                int right = 0;
                int pointer;
                bool found = false;

                for (int i = 0; i < size; i++)
                    total += numbers[i];

                //Console.WriteLine(total); // Passed

                for (int i = 0; i < size; i++)
                {
                    pointer = numbers[i];
                    right = total - pointer - left;

                    //Console.WriteLine("Left:{0} Right:{1} Pointer:{2}", left, right, pointer);

                    if (left == right)
                    {
                        found = true;
                        break;
                    }

                    left += pointer;
                }

                if (found)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                tc--;
            }
        }
    }
}
