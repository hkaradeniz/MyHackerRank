using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            RotateLeft();
            RotateRight();
            Console.ReadLine();
        }

        static void RotateLeft()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] shiftedArray = new int[arr.Length];
            int numberOfShifts = 4;

            int lenght = arr.Length;

            for (int i = 0; i < lenght; i++)
            {
                shiftedArray[(i + (numberOfShifts - lenght)) % lenght] = arr[i];
            }

            foreach (var item in shiftedArray)
            {
                Console.Write("{0} ", item);
            }
        }

        static void RotateRight()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] shiftedArray = new int[arr.Length];
            int numberOfShifts = 4;

            int lenght = arr.Length;

            for (int i = 0; i < lenght; i++)
            {
                shiftedArray[(i + numberOfShifts + lenght) % lenght] = arr[i];
            }

            foreach (var item in shiftedArray)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
