namespace BinaryTreeTraversal
{
    public class Tree
    {
        public Node Root { get; private set; }

        public Node Insert(Node node, int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (node == null)
            {
                var newOne = new Node(data);

                if (Root == null)
                {
                    Root = newOne;
                }

                return newOne;
            }
            else
            {
                // 2. Otherwise, recur down the tree
                if (data <= node.Value)
                {
                    node.Left = Insert(node.Left, data);
                }
                else
                {
                    node.Right = Insert(node.Right, data);
                }
            }

            return node;
        }
    }
}
