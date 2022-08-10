# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution(object):
    def reverseList(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """        
        cur = head
        prev = None

        while (cur != None):
            next = cur.next 
            cur.next = prev            
            prev = cur
            cur = next

        return prev
    
node1 = ListNode(1)
node2 = ListNode(2)
node3 = ListNode(3)
node4 = ListNode(4)
node5 = ListNode(5)

node1.next = node2
node2.next = node3
node3.next = node4
node4.next = node5

s = Solution()
rev1 = s.reverseList(node1)

cur = rev1

while (cur != None):
    print(str(cur.val) + " ")
    cur = cur.next
        
