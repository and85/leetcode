using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode startNode = new ListNode(0);
            ListNode mergedList = startNode;

            while (true)
            {
                if (l1 == null)
                {
                    mergedList.next = l2;
                    break;
                }
                if (l2 == null)
                {
                    mergedList.next = l1;
                    break;
                }

                if (l1.val < l2.val)
                {
                    mergedList.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    mergedList.next = l2;
                    l2 = l2.next;
                }

                mergedList = mergedList.next;
            }

            return startNode.next;
        }
    }
}
