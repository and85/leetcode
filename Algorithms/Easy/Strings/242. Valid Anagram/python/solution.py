import collections


class Solution(object):
    def isAnagram(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: bool
        """
        
        source = collections.Counter(s)        

        for c in t:
            if source.__contains__(c):
                source[c] -= 1
            else:
                return False
        
        return all(v == 0 for v in source.values())        


s = Solution
print(s.isAnagram(s, "anagram", "nagaram"))
print(s.isAnagram(s, "rat", "car"))


