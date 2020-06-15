using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            char[] array = s.ToCharArray();

            int pointer1 = 0, pointer2 = s.Length - 1;
            while (pointer1 < pointer2)
            {
                if (!IsVowel(array[pointer1]))
                    pointer1++;
                else if (!IsVowel(array[pointer2]))
                    pointer2--;
                else
                {
                    Swap(array, pointer1, pointer2);
                    pointer1++;
                    pointer2--;
                }
            }

            return new string(array);
        }

        private void Swap(char[] array, int pointer1, int pointer2)
        {
            char temp = array[pointer1];
            array[pointer1] = array[pointer2];
            array[pointer2] = temp;
        }

        private bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }
    }
}
