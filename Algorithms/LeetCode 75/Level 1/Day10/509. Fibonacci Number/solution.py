class Solution(object):
    def fib_ON(self, n):
        """
        :type n: int
        :rtype: int
        """
        if (n == 0): 
            return 0
        
        if (n == 1): 
            return 1
                
        prevPrev = 0
        prev = 1

        i = 2
        while (i <= n):
            cur = prevPrev + prev
            prevPrev = prev
            prev = cur
            i += 1
        
        return cur

    def fib_ON(self, n):
        """
        :type n: int
        :rtype: int
        """
        if (n == 0): 
            return 0
        
        if (n == 1): 
            return 1
        
        dp = [None] * (n + 1)
        dp[0] = 0
        dp[1] = 1

        i = 2
        while (i <= n):
            dp[i] = dp[i - 1] + dp[i - 2]
            i += 1
        
        return dp[-1]

s = Solution()
print(s.fib(2))
print(s.fib(3))
print(s.fib(4))