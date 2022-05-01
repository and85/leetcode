using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            
            var dict = new Dictionary<Node, Node>();
            
            Node curr = head;
            Node copyhead = GetCopy(head, dict);                                    

            while (curr != null)
            {
                var copy = GetCopy(curr, dict);
                copy.next = GetCopy(curr.next, dict);
                copy.random = GetCopy(curr.random, dict);
                
                curr = curr.next;
            }

            return copyhead;
        }

        private Node GetCopy(Node key, Dictionary<Node, Node> dict)
        {
            if (key == null) return null;

            if (!dict.ContainsKey(key))
            {
                dict.Add(key, new Node(key.val));
            }
            
            return dict[key];
        }
    }
}
