using System;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int cutLenght;
            MyLinkedList linkedList = new MyLinkedList();
            //6
            //5 4 4 2 2 8
            foreach (var item in arr)
            {
                linkedList.AddLast(item);
            }

            while (n > 0)
            {
                Console.WriteLine(n);
                cutLenght = GetCutLenght(linkedList);
                Node current = linkedList.Head;

                while (current != null)
                {
                    current.Value = current.Value - cutLenght;
                    if (current.Value < 1)
                    {
                        linkedList.Remove(current.Value);
                        n--;
                    }
                    current = current.Next;
                }
            }
        }

        static int GetCutLenght(MyLinkedList ll)
        {
            int cutLenght = 1001;
            Node current = ll.Head;

            while (current != null)
            {
                if (cutLenght > current.Value)
                    cutLenght = current.Value;

                current = current.Next;
            }

            return cutLenght;
        }
    }
}
