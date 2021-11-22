using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        Dictionary<int, int> _occurrences = new Dictionary<int, int>();

        public int[] FindMode(TreeNode root)
        {
            DfsInorder(root);

            int max = _occurrences.Max(o => o.Value);
            var keysToDelete = new HashSet<int>();
            foreach (var o in _occurrences)
            {
                if (_occurrences[o.Key] < max)
                    keysToDelete.Add(o.Key);
            }

            foreach (var k in keysToDelete)
                _occurrences.Remove(k);

            return _occurrences.Select(o => o.Key).ToArray();
        }

        private void DfsInorder(TreeNode root)
        {
            if (root == null) return;

            DfsInorder(root.left);

            if (!_occurrences.ContainsKey(root.val))
                _occurrences.Add(root.val, 1);
            else
                _occurrences[root.val]++;

            DfsInorder(root.right);


        }
    }
}
