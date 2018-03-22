namespace BinaryTreeTraversal
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}
