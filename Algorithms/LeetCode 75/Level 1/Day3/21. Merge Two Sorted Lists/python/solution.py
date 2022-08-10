# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def mergeTwoLists(self, l1, l2):
        """
        :type list1: Optional[ListNode]
        :type list2: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        if (l1 == None and l2 == None): 
            return None
        if (l1 == None): 
            return l2
        if (l2 == None): 
            return l1

        sentinelHead = ListNode(0)
        cur = sentinelHead

        while (l1 != None or l2 != None):        
            if (l1 == None):            
                cur.next = l2
                break            
            elif (l2 == None):            
                cur.next = l1
                break            
            elif (l1.val < l2.val):            
                cur.next = l1
                l1 = l1.next
                cur = cur.next            
            elif (l1.val >= l2.val):                                  
                cur.next = l2
                l2 = l2.next
                cur = cur.next                    

        return sentinelHead.next