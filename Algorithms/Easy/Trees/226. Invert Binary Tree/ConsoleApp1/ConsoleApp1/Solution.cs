using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            treeNodes.Push(root);

            TreeNode tempNode;
            TreeNode nextNode;
            while (treeNodes.Count != 0)
            {
                nextNode = treeNodes.Pop();

                tempNode = nextNode.left;
                nextNode.left = nextNode.right;
                nextNode.right = tempNode;

                if (nextNode.left != null)
                    treeNodes.Push(nextNode.left);
                if (nextNode.right != null)
                    treeNodes.Push(nextNode.right);
            }

            return root;

        }
    }
}
