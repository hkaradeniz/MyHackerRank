using System;

namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            Int64 total = 0;
            bool result = false;

            for (Int64 pointer = low; pointer <= high; pointer++)
            {
                total = pointer * pointer;
                string strTotal = total.ToString();
                int right = 0;
                int length = strTotal.Length;

                if (length % 2 == 0)
                {
                    right = length / 2;
                }
                else
                {
                    right = length / 2 + 1;
                }

                string strFirstPortion = "0" + strTotal.Substring(0, length - right);
                string strSecondPortion = strTotal.Substring(length - right);

                if (Int64.Parse(strFirstPortion) + Int64.Parse(strSecondPortion) == pointer)
                {
                    result = true;
                    Console.Write(pointer); Console.Write(" ");
                }
            }

            if (!result)
            {
                Console.Write("INVALID RANGE");
            }

            #region 
            /* Real Solution
               for(int pointer=low; pointer<high; pointer++)
               {
                   total = pointer*pointer;
                   int div = 10;

                   if (total < 10)
                       {
                           if (0 + total == pointer)
                           {
                               result = true;
                               Console.Write(pointer); Console.Write(" ");
                           }
                       }
                       else
                       {
                           while (div < total)
                           {
                               int left = total / div;
                               int right = total % div;

                               if (left + right == pointer)
                               {
                                   result = true;
                                   Console.Write(pointer); Console.Write(" ");
                                   break;
                               }

                               div *= 10;
                           }
                       }
               }

               if(!result)
               {
                   Console.WriteLine("INVALID RANGE");    
               }
               */
            #endregion
        }
    }
}
