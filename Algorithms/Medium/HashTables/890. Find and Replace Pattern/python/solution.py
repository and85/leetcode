from typing import Pattern


class Solution(object):
    def findAndReplacePattern(self, words, pattern):
        """
        :type words: List[str]
        :type pattern: str
        :rtype: List[str]
        """
        result = []
        
        for word in words: 
            if len(word) != len(pattern):
                 continue
            
            if self.patternMatch(word, pattern):
                result.append(word)

        return result

    def patternMatch(self, word, pattern):
        """
        """
        dict = {}
        mapped = set()        

        i = 0
        while i < len(word):
            p = pattern[i]
            w = word[i]

            if p in dict:
                if (w != dict[p]):
                     return False
            else:
                if (w in mapped):
                     return False

                mapped.add(w)
                dict[p] = w                

            i += 1

        return True

words = ["abc","deq","mee","aqq","dkd","ccc"]
pattern = "abb"

s = Solution()
list = s.findAndReplacePattern(words, pattern)
print(list)


