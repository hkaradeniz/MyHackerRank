using System;
using System.Linq;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(s.Count(c => char.IsUpper(c)) + 1);
        }
    }
}
