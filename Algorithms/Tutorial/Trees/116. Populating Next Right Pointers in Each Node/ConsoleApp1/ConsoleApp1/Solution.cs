using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null) return root;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                Node prev = null;
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();                    
                    
                    if (prev != null)
                    {
                        prev.next = node;
                    }

                    prev = node;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }

            return root;
        }
    }
}
