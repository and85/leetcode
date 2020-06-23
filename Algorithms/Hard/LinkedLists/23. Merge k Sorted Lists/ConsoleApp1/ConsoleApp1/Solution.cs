using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            int k = lists.Length;
            var resultDummyHead = new ListNode();
            var curr = resultDummyHead; 

            while (!AllPointersAreNull(lists))
            {
                int minListIndex = GetMinListIndex(lists);
                curr.next = new ListNode();
                curr = curr.next;
                curr.val = lists[minListIndex].val;

                lists[minListIndex] = lists[minListIndex].next;
            }

            return resultDummyHead.next;
        }

        private int GetMinListIndex(ListNode[] lists)
        {
            int min = int.MaxValue;
            int minIndex = int.MaxValue;

            for (int i = 0; i < lists.Length; i++)
            {
                if ((lists[i]?.val ?? int.MaxValue) < min)
                {
                    min = lists[i].val;
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private bool AllPointersAreNull(ListNode[] lists)
        {
            return lists.All(l => l == null);
        }
    }
}
