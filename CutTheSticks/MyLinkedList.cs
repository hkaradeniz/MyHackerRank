namespace CutTheSticks
{
    class MyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void ClearLinkedList()
        {
            Head = null;
        }

        public Node First()
        {
            return Head;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Tail = newNode;
                Head = Tail;
            }
            else
            {
                Tail = Tail.Next = newNode;
            }
        }

        public void Remove(int value)
        {
            Node current = Head;
            Node previous = current;

            while (current != null)
            {
                if (current.Value == value)
                {
                    // Bingo Delete it
                    // Dont remove the head;
                    if (current.Value == Head.Value)
                    {
                        Head = Head.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    break;
                }
                previous = current;
                current = current.Next;
            }
        }
    }
}
