import random
import copy

class Solution(object):

    __nums = []
    __numsCopy = []

    def __init__(self, nums):
        """
        :type nums: List[int]
        """          
        self.__numsCopy = self.arrayCopy(nums)
        self.__nums = nums              
        

    def reset(self):
        """
        :rtype: List[int]
        """        
        self.__nums = self.arrayCopy(self.__numsCopy)
        return self.__nums
        

    def shuffle(self):
        """
        :rtype: List[int]
        """
        # Knuth Shuffle implementation        
        i = 1
        while (i < len(self.__nums)):        
            r = random.randint(0, i)
            self.swap(i, r)
            i += 1

        return self.__nums
    
    def swap(self, i, j):
        """
        """        
        t = self.__nums[i]
        self.__nums[i] = self.__nums[j]
        self.__nums[j] = t    

    def arrayCopy(self, src):
        l = len(src)
        dest = [None] * l 
        for i in range(l):
            dest[i] = src[i]

        return dest
                

# Your Solution object will be instantiated and called as such:

nums = [1, 2, 3, 4, 5]
obj = Solution(nums)

param_2 = obj.shuffle()
param_1 = obj.reset()

print(param_1)
print(param_2)