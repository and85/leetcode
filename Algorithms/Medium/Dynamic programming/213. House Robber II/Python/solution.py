class Solution(object):               
    def rob(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        def robStartingFromHouse(firstHouse, lastHouse, nums):    
            cur = 0 
            dp1 = nums[firstHouse]
            dp0 = 0

            i = firstHouse
            while (i <= lastHouse):
                                
                prev = cur
                cur = max(dp0 + nums[i], dp1)

                dp1 = cur
                dp0 = prev
                i += 1        

            return cur    

        if (len(nums) == 1): 
            return nums[0]
        
        startFromFirst = robStartingFromHouse(0, len(nums) - 2, nums)
        startFromSecond = robStartingFromHouse(1, len(nums) - 1, nums)
        
        return max(startFromFirst, startFromSecond)

    