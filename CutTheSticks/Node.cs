namespace CutTheSticks
{
    class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }
}
