using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private Dictionary<Node, Node> _map = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(node);                        

            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                
                if (_map.ContainsKey(cur))
                {
                    continue;
                }

                Node  cl = new Node(cur.val);
                _map.Add(cur, cl);                

                foreach (var child in cur.neighbors)
                {                    
                    var clonedChild = new Node(child.val);                    
                    cl.neighbors.Add(clonedChild);
                    
                    _map.Add(child, clonedChild);

                    queue.Enqueue(child);
                }

            }


            return _map[node];
        }
    }
}
