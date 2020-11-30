using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionRecursive
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var list = new List<int>();

            Helper(root, list);

            return list;
        }

        private void Helper(TreeNode root, List<int> list)
        {
            if (root == null)
                return;

            Helper(root?.left, list);
            Helper(root?.right, list);

            list.Add(root.val);
        }
    }
}
