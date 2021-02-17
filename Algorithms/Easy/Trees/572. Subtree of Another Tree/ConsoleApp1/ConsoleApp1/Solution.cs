using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            var sl = new List<int>();
            var tl = new List<int>();
            PreOder(t, tl);

            return CheckEachNode(s, tl);
        }

        private bool CheckEachNode(TreeNode s, List<int> tl)
        {
            if (s == null)
                return false;
            
            var sl = new List<int>();
            PreOder(s, sl);

            if (Enumerable.SequenceEqual(tl, sl))
                return true;
            
            return CheckEachNode(s.left, tl) || CheckEachNode(s.right, tl);
        }

        private void PreOder(TreeNode root, List<int> res)
        {
            if (root == null)
            {
                res.Add(-1);
                return;
            }

            res.Add(root.val);
            PreOder(root.left, res);
            PreOder(root.right, res);
        }
    }
}
