using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GenerateInput();

            var tree = new Tree();
            var node = (Node)null;

            foreach (var value in input)
            {
                node = tree.Insert(node, value);
            }

            var dfsTraversal = new DfsTraversal();

            Console.WriteLine("DFS. In-order");
            var dfsInorderResult = new List<int>();
            dfsTraversal.Inorder(tree.Root, dfsInorderResult);
            Console.WriteLine(string.Join(',', dfsInorderResult));

            Console.WriteLine("DFS. Pre-order");
            var dfsPreorderResult = new List<int>();
            dfsTraversal.Preorder(tree.Root, dfsPreorderResult);
            Console.WriteLine(string.Join(',', dfsPreorderResult));

            var dfsPostorderResult = new List<int>();
            Console.WriteLine("DFS. Post-order");
            dfsTraversal.Postorder(tree.Root, dfsPostorderResult);
            Console.WriteLine(string.Join(',', dfsPostorderResult));

            Console.WriteLine("BFS. Traverse");
            var bfsTraversal = new BfsTraversal();
            var bfsResult = new List<int>();
            bfsTraversal.Traverse(tree.Root, bfsResult);
            Console.WriteLine(string.Join(',', bfsResult));

            var sumCheck = input.Sum(_ => _);
            if (sumCheck == dfsInorderResult.Sum(_ => _) && sumCheck == dfsPreorderResult.Sum(_ => _) && sumCheck == dfsPostorderResult.Sum(_ => _) && sumCheck == bfsResult.Sum(_ => _))
            {
                Console.WriteLine("Sum check is correct: {0}", sumCheck);
            }
            else
            {
                Console.WriteLine("Something went wrong. Sum check is not correct.");
            }

            Console.ReadKey();
        }

        private static IEnumerable<int> GenerateInput()
        {
            const int count = 100;
            const int minValue = 0;
            const int maxValue = 20;

            var random = new Random();

            return Enumerable.Repeat(0, count).Select(i => random.Next(minValue, maxValue)).ToArray();
        }
    }
}
