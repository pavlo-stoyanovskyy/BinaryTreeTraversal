
using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    /// <summary>
    /// DFS - Depth-first search (Inorder, Preorder, Postorder)
    /// </summary>
    public class DfsTraversal
    {
        /// <summary>
        /// Inorder Traversal (Left-Root-Right)
        /// </summary>
        public void Inorder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                Inorder(node.Left, valueList);
                valueList.Add(node.Value);
                Inorder(node.Right, valueList);
            }
        }

        /// <summary>
        /// Preorder Traversal (Root-Left-Right)
        /// </summary>
        public void Preorder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                valueList.Add(node.Value);
                Preorder(node.Left, valueList);
                Preorder(node.Right, valueList);
            }
        }

        /// <summary>
        /// Postorder Traversal (Left-Right-Root)
        /// </summary>
        public void Postorder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                Postorder(node.Left, valueList);
                Postorder(node.Right, valueList);
                valueList.Add(node.Value);
            }
        }
    }
}
