class Solution(object):
    def pivotIndex(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        l = len(nums)        

        totalSum = sum(nums)
        leftSum = 0

        for i in range(0, l):
            if (leftSum == totalSum - leftSum - nums[i]):
                return i
            leftSum += nums[i]

        return -1

s = Solution()
print(s.pivotIndex([1,7,3,6,5,6]))
print(s.pivotIndex([1,2,3]))
print(s.pivotIndex([2,1,-1]))
print(s.pivotIndex([-1,-1,0,1,1,0]))
print(s.pivotIndex([0]))