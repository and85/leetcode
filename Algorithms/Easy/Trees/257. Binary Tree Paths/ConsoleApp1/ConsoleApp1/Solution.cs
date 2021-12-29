using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public class Item
        {
            public Item(TreeNode node, string path)
            {
                Node = node;
                Path = path;
            }

            public TreeNode Node { get; private set; }
            public string Path { get; set; }
        }
            
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var result = new List<string>();
            var queue = new Queue<Item>();
            queue.Enqueue(new Item(root, ""));

            while (queue.Count > 0)
            {

                var node = queue.Dequeue();
                node.Path += node.Node.val.ToString() + " ";

                if (node.Node.left == null && node.Node.right == null)
                {
                    result.Add(node.Path.Trim().Replace(" ", "->"));
                }

                if (node.Node.left != null)
                    queue.Enqueue(new Item(node.Node.left, node.Path));

                if (node.Node.right != null)
                    queue.Enqueue(new Item(node.Node.right, node.Path));
            }

            return result;
        }

        
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
