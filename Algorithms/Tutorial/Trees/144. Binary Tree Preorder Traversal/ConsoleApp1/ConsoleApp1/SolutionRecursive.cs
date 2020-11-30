using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionRecursive
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            Traverse(root, result);

            return result;
        }

        private void Traverse(TreeNode root, IList<int> result)
        {
            if (root == null)
                return;

            result.Add(root.val);

            Traverse(root.left, result);
            Traverse(root.right, result);
        }
    }
}
