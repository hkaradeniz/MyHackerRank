using System;

namespace Palindrome
{
    class Program
    {
        //A palindrome has the same letters on both ends of the string. 
        //This means "civic" is a palindrome, but "perls" is not.

        static void Main(string[] args)
        {
            IsPalindrome("civic");
            Console.ReadLine();
        }

        static bool IsPalindrome(string word)
        {
            int head = 0;
            int tail = word.Length - 1;

            if (!String.IsNullOrEmpty(word))
            {
                while (true)
                {
                    if (head > tail)
                        return true;

                    char a = word[head];
                    char b = word[tail];

                    if (char.ToLower(a) != char.ToLower(b))
                        return false;

                    head++;
                    tail--;
                }
            }

            return false;
        }
    }
}
