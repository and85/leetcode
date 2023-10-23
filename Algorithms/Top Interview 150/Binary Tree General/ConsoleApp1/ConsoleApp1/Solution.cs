using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;            

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
