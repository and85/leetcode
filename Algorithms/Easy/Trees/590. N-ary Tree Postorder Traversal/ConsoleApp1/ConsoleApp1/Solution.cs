using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> Postorder(Node root)
        {
            return Traverse(root, new List<int>());
        }

        public IList<int> Traverse(Node root, List<int> res)
        {
            if (root == null)
                return res;

            foreach (var child in root.children)
                Traverse(child, res);

            res.Add(root.val);

            return res;
        }
    }
}
