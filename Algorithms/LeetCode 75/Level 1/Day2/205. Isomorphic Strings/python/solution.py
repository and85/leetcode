class Solution(object):
    def isIsomorphic(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: bool
        """
        map = dict()
        usedT = set()

        for i in range(0, len(s)):
            if (s[i] not in map):
                if (t[i] in usedT):
                     return False
                usedT.add(t[i])
                map[s[i]] = t[i]
            else:
                if (t[i] != map[s[i]]):
                    return False
        
        return True

s = Solution()
print(s.isIsomorphic("egg", "add"))
print(s.isIsomorphic("foo", "bar"))
print(s.isIsomorphic("paper", "title"))
