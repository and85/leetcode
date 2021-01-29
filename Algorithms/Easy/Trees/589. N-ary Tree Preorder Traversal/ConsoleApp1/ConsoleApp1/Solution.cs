using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();

            TraverseTree(root, result);

            return result;

        }

        private void TraverseTree(Node root, List<int> result)
        {
            if (root == null)
                return;

            var stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                
                var node = stack.Pop();

                result.Add(node.val);

                foreach (var child in node.children.Reverse())
                {
                    stack.Push(child);
                }
            }
        }
    }
}
