using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        Dictionary<Node, Node> _visitedNodes = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return node;
            }

            if (_visitedNodes.ContainsKey(node))
                return _visitedNodes[node];

            Node clonedNode = new Node(node.val, new List<Node>());
            _visitedNodes.Add(node, clonedNode);

            foreach (var neighbor in node.neighbors)
            {
                clonedNode.neighbors.Add(CloneGraph(neighbor));
            }

            return clonedNode;
        }
    }
}
