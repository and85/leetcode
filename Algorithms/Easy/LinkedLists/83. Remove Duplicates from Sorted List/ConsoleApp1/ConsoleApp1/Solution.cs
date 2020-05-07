using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode headRef = new ListNode();
            headRef.next = head;

            while (head != null)
            {
                ListNode nextNode = head.next;
                if (head.next != null && head.val == head.next.val)
                {
                    while (nextNode != null && nextNode.val == head.val)
                    {
                        nextNode = nextNode.next;
                    }
                    head.next = nextNode;
                    
                }
                
                head = head.next;
            }

            return headRef.next;
        }
    }
}
