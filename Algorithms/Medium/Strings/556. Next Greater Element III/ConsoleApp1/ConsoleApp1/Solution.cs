using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NextGreaterElement(int n)
        {
            string nStr = n.ToString();

            if (n < 10 || IsNonIncreasingSequence(nStr))
                return -1;

            for (int i = nStr.Length - 1; i >= 1; i--)
            {
                int k = i - 1;
                if (nStr[i] > nStr[k])
                {
                    char min = char.MaxValue;
                    int minIndex = k;

                    for (int j = i; j < nStr.Length; j++)
                    {
                        if (nStr[j] > nStr[k] && nStr[j] < min)
                        {
                            min = nStr[j];
                            minIndex = j;
                        }
                    }

                    string swappedStr = nStr.Substring(k, nStr.Length - k);
                    swappedStr = SwapChars(nStr, k, minIndex);

                    string newStrStart = swappedStr.Substring(0, i);
                    string newStrEnd = SortString(swappedStr.Substring(i, swappedStr.Length - i));

                    string newStr = newStrStart + newStrEnd;

                    return int.TryParse(newStr, out int res) ? res : -1;
                }

            }

            return 0;
        }

        private string SwapChars(string str, int index1, int index2)
        {
            char[] chars = str.ToCharArray();

            char c1 = chars[index1];
            char c2 = chars[index2];

            chars[index1] = c2;
            chars[index2] = c1;

            return new string(chars);
        }

        private string SortString(string str)
        {
            return string.Concat(str.OrderBy(c => c));
        }

        private bool IsNonIncreasingSequence(string nStr)
        {
            for (int i = 1; i < nStr.Length; i++)
            {
                if (nStr[i] > nStr[i - 1])
                    return false;
            }

            return true;
        }
    }
}
