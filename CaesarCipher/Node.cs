using System;

namespace CaesarCipher
{
    class Node
    {
        public Node Next { get; set; }
        public string Value { get; set; }

        public Node(string val)
        {
            Value = val;
        }

        public void DisplayNode()
        {
            Console.WriteLine("Value: " + Value);
        }
    }
}
