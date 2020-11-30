using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            var reverseStack = new Stack<int>();
            var tempStack = new Stack<TreeNode>();
            tempStack.Push(root);

            // mirror preoder (root right left, but not root left right)
            while (tempStack.Count > 0)
            {
                var node = tempStack.Pop();
                if (node == null)
                    break;
                reverseStack.Push(node.val);

                if (node.left != null)
                    tempStack.Push(node.left);

                if (node.right != null)
                    tempStack.Push(node.right);
            }

            while (reverseStack.Count > 0)
                result.Add(reverseStack.Pop());

            return result;
        }

        // https://www.geeksforgeeks.org/iterative-postorder-traversal-using-stack/?ref=lbp
        private TreeNode _root;
        List<int> _list = new List<int>();

        public IList<int> PostorderTraversalOneStack(TreeNode node)
        {
            Stack<TreeNode> S = new Stack<TreeNode>();

            // Check for empty tree 
            if (node == null)
                return _list;
            S.Push(node);
            TreeNode prev = null;
            while (S.Count > 0)
            {
                TreeNode current = S.Peek();

                /* go down the tree in search of a leaf an if so process it  
                and pop stack otherwise move down */
                if (prev == null || prev.left == current ||
                                            prev.right == current)
                {
                    if (current.left != null)
                        S.Push(current.left);
                    else if (current.right != null)
                        S.Push(current.right);
                    else
                    {
                        S.Pop();
                        _list.Add(current.val);
                    }

                    /* go up the tree from left node, if the child is right  
                       push it onto stack otherwise process parent and pop  
                       stack */
                }
                else if (current.left == prev)
                {
                    if (current.right != null)
                        S.Push(current.right);
                    else
                    {
                        S.Pop();
                        _list.Add(current.val);
                    }

                    /* go up the tree from right node and after coming back 
                     from right node process parent and pop stack */
                }
                else if (current.right == prev)
                {
                    S.Pop();
                    _list.Add(current.val);
                }

                prev = current;
            }

            return _list;
        }
    }
}
