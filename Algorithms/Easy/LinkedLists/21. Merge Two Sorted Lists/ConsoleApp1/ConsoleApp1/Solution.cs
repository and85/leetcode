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
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode senitelHead = new ListNode(0);
            ListNode cur = senitelHead;


            while (l1 != null || l2 != null)
            {
                if ((l1 != null && l2 != null) && (l1.val < l2.val))
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else if((l1 != null && l2 != null) && (l1.val >= l2.val))
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                else if (l1 == null)
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }

                cur = cur.next;
            }

            return senitelHead.next;
        }

        public ListNode MergeTwoLists_Attempt1(ListNode l1, ListNode l2)
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
