using System;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int numOfMessages = S.Length / 3;
            int changedChars = 0;

            //SOSSPSSQSSOR
            for (int i = 0; i < numOfMessages; i++)
            {
                string msg = S.Substring(i * 3, 3);
                if (msg != "SOS")
                {
                    if (msg[0] != 'S')
                        changedChars++;

                    if (msg[1] != 'O')
                        changedChars++;

                    if (msg[2] != 'S')
                        changedChars++;
                }
            }

            Console.WriteLine(changedChars);
        }
    }
}
