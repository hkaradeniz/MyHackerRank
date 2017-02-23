using System;
using System.Linq;

namespace BiggerIsGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int tc = Int32.Parse(Console.ReadLine());

            while (tc > 0)
            {
                string str = Console.ReadLine();
                int strLenght = str.Length;
                int stopPoint = 0;
                char[] strArr = str.ToCharArray();

                for (int i = strLenght - 1; i > 0; i--)
                {
                    // integer comparison via chars
                    if (str[i] > str[i - 1])
                    {
                        stopPoint = i;
                        break;
                    }
                }

                if (stopPoint == 0)
                {
                    Console.WriteLine("no answer");
                }
                else
                {
                    int x = strArr[stopPoint - 1];
                    int smallest = stopPoint;
                    for (int j = stopPoint - 1; j < strLenght; j++)
                        if (strArr[j] > x && str[j] < strArr[smallest])
                            smallest = j;


                    // Swap
                    char temp = strArr[smallest];
                    strArr[smallest] = strArr[stopPoint - 1];
                    strArr[stopPoint - 1] = temp;

                    str = new string(strArr);
                    string head = str.Substring(0, stopPoint);
                    string tail = str.Substring(stopPoint);


                    tail = String.Concat(tail.OrderBy(c => c));
                    Console.WriteLine("{0}{1}", head, tail);
                }

                tc--;
            }
        }
    }
}
