using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string stdin = Console.ReadLine();

            Dictionary<char, bool> alphabet = new Dictionary<char, bool>();
            alphabet.Clear();
            alphabet.Add('a', false);
            alphabet.Add('b', false);
            alphabet.Add('c', false);
            alphabet.Add('d', false);
            alphabet.Add('e', false);
            alphabet.Add('f', false);
            alphabet.Add('g', false);
            alphabet.Add('h', false);
            alphabet.Add('i', false);
            alphabet.Add('j', false);
            alphabet.Add('k', false);
            alphabet.Add('l', false);
            alphabet.Add('m', false);
            alphabet.Add('n', false);
            alphabet.Add('o', false);
            alphabet.Add('p', false);
            alphabet.Add('q', false);
            alphabet.Add('r', false);
            alphabet.Add('s', false);
            alphabet.Add('t', false);
            alphabet.Add('u', false);
            alphabet.Add('v', false);
            alphabet.Add('w', false);
            alphabet.Add('x', false);
            alphabet.Add('y', false);
            alphabet.Add('z', false);
            //26

            char[] array = stdin.ToLower().ToCharArray();

            foreach (char character in array)
            {
                if (alphabet.ContainsKey(character))
                {
                    alphabet[character] = true;
                }
            }


            if (alphabet.ContainsValue(false))
            {
                Console.WriteLine("not pangram");
            }
            else
            {
                Console.WriteLine("pangram");
            }

        }
    }
}
