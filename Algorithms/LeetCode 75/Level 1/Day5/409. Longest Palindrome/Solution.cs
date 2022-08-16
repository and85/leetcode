public class Solution
    {
        public int LongestPalindrome(string s)
        {
            int[] count = new int[52];

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    count[s[i] - 'A']++;
                }
                else
                {
                    count[s[i] - 'a' + 26]++;
                }
            }

            int odd = 0, len = 0;            
            for (int i = 0; i < 52; i++)
            {
                if (count[i] % 2 == 1)
                {
                    odd = 1;
                    count[i] -= 1;
                }

                len += count[i];
            }

            return len + odd;
        }
    }