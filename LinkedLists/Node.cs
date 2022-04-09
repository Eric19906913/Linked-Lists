namespace LinkedLists
{
    public class Node
    {
        // A pointer to the next node
        public Node Next { get; set; } = null!;

        // Data stored in the node
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}
