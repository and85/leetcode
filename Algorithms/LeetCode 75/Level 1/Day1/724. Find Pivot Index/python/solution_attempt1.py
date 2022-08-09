class Solution(object):
    def pivotIndex(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        l = len(nums)        

        if (l == 1):
            return 0

        lefts = [0] * l
        rights = [0] * l

        lefts[0] = nums[0]
        rights[(l - 1)] = nums[l - 1]

        for i in range(1, l):
            lefts[i] = nums[i] + lefts[i - 1]

        for i in range(l - 2, 0, -1):
            rights[i] = nums[i] + rights[i + 1]

        for i in range(0, l):
            if (i == 0 and rights[1] == 0):
                 return 0
            if (i == l - 1 and lefts[i - 1] == 0):
                 return i

            if (i > 0 and i < l - 1 and lefts[i - 1] == rights[i + 1]):
                return i

        return -1

s = Solution()
print(s.pivotIndex([1,7,3,6,5,6]))
print(s.pivotIndex([1,2,3]))
print(s.pivotIndex([2,1,-1]))
print(s.pivotIndex([-1,-1,0,1,1,0]))
print(s.pivotIndex([0]))