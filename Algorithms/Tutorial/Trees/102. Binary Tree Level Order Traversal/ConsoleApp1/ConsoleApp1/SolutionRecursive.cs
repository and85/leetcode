using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionRecursive
    {
        List<IList<int>> _levels = new List<IList<int>>();

        public void Helper(TreeNode node, int level)
        {
            // start the current level
            if (_levels.Count == level)
                _levels.Add(new List<int>());

            // fulfil the current level
            _levels[level].Add(node.val);

            // process child nodes for the next level
            if (node.left != null)
                Helper(node.left, level + 1);
            if (node.right != null)
                Helper(node.right, level + 1);
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) 
                return _levels;
            
            Helper(root, 0);
            
            return _levels;
        }
    }
}
