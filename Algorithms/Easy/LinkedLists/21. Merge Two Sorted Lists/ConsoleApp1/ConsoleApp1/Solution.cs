using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            //var sentinelHead = new ListNode();
            //Recursive1(sentinelHead, l1, l2);
            //return sentinelHead.next;

            if (list1 == null && list2 == null) return null;

            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }


            if (list1.val <= list2.val)
            {

                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {

                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }

        private void Recursive1(ListNode result, ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null) result.next = null;

            if (list1 == null)
            {
                result.next = list2;
                return;
            }
            if (list2 == null)
            {
                result.next = list1;
                return;
            }

            if (list1.val <= list2.val)
            {
                result.next = list1;
                Recursive1(result.next, list1.next, list2);
            }
            else
            {
                result.next = list2;
                Recursive1(result.next, list1, list2.next);
            }
        }

        public ListNode MergeTwoLists_Attempt2(ListNode l1, ListNode l2)
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
