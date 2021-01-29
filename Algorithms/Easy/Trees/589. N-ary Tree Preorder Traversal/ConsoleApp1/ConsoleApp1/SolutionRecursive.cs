using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SolutionRecursive
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

            result.Add(root.val);
            foreach (var child in root.children)
            {
                TraverseTree(child, result);
            }
        }
    }
}
