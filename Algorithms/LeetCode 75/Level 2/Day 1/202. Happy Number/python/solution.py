class Solution(object):
    def getNextMutation(self, n):
        result = 0
        while (n != 0):
            result += (n % 10) ** 2
            n = n / 10
        
        return result

    def isHappy(self, n):
        """
        :type n: int
        :rtype: bool
        """
        seen = set()
        seen.add(n)

        while (n != 1):
            n = self.getNextMutation(n)
            if (n in seen): 
                return False
            seen.add(n)
        
        return True

    