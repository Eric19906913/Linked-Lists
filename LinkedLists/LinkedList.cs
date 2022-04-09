namespace LinkedLists
{
    public class LinkedList
    {
        // The head of the linked list
        public Node Head { get; set; } = null!;

        // Add a new element to the end of the linked list.
        public void Append(int data)
        {
            // If the head is null we create it
            if (Head == null)
            { 
                Head = new Node(data);
                return;
            }
            // take the head as the current node
            var current = Head;

            // Move for the list until we find a null node
            // this means that we are in the end of the list.
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
        }

        // Add a new element to the start of the new list.
        public void Prepend(int data)
        {
            // Creates a new head set the current head as its current node and
            // set the new node as the head.
            var newHead = new Node(data);
            newHead.Next = Head;
            Head = newHead;

        }

        public void DeleteWithValue(int value)
        {
            if (Head == null)
            {
                return;
            }

            // If the data that we want to delete is in the first node
            // we set the head to the next node.
            if (Head.Data == value)
            { 
                Head = Head.Next;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                // If we find the value we remove the node from the linked list 
                // setting the next to the one next to the next to it.
                if (current.Next.Data == value)
                { 
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void PrintList()
        {
            if (Head == null)
            {
                return;
            }

            var current = Head;
            while (current != null)
            { 
                Console.Write($"{current.Data}, ");
                current = current.Next;
            }


        }
    }
}
