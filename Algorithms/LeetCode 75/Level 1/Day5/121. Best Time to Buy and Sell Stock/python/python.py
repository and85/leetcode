from cmath import inf


class Solution(object):
    def maxProfit(self, prices):
        """
        :type prices: List[int]
        :rtype: int
        """
        maxProfit = 0
        minSeen = float('inf')

        for p in prices:
            minSeen = min(minSeen, p)
            maxProfit = max(maxProfit, p - minSeen)

        return maxProfit