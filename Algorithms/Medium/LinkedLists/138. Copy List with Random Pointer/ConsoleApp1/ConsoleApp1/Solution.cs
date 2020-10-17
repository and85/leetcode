using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        Dictionary<Node, Node> _clones = new Dictionary<Node, Node>();

        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            Node cloneDummyHead = new Node(0);
            Node curr = head;
            Node currClone = cloneDummyHead;

            while (curr != null)
            {
                Node clone = GetClone(curr);
                clone.random = GetClone(curr.random);
                currClone.next = clone;

                currClone = currClone.next;
                curr = curr.next;
            }

            return cloneDummyHead.next;
        }

        private Node GetClone(Node node)
        {
            if (node == null)
                return null;

            if (_clones.ContainsKey(node))
            {
                return _clones[node];
            }
            Node clone = new Node(node.val);
            _clones.Add(node, clone);

            return clone;

        }
    }
}
