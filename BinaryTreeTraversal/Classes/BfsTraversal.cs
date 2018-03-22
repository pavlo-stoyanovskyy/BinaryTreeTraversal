
using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    /// <summary>
    /// BFS - Breadth-first search (or level order traversal)
    /// </summary>
    public class BfsTraversal
    {
        /// <summary>
        /// Breadth-first search is an algorithm for traversing or searching tree where
        /// it starts at the tree root and explores the neighbor nodes first, before moving to the next level neighbours.
        /// </summary>
        public void Traverse(Node node, List<int> valueList)
        {
            var q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                if (current == null)
                {
                    continue;
                }
                q.Enqueue(current.Left);
                q.Enqueue(current.Right);

                valueList.Add(current.Value);
            }
        }
    }
}
