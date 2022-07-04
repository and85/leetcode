using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution_attempt1
    {
        private int prime = 101;

        // implementation of Rabin-Karp algorithm
        // https://www.youtube.com/watch?v=H4VrKHVG5qI&t=278s
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int patternLen = s1.Length;
            string candidate = s2.Substring(0, patternLen);

            long patternHash = CreateHash(s1, patternLen);
            long candidateHash = CreateHash(candidate, patternLen);

            var patternEntries = s1.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
            var candidateEntries = candidate.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            for (int i = 1; i <= s2.Length - patternLen + 1; i++)
            {
                if (CheckEqual(patternHash, candidateHash, patternEntries, candidateEntries))
                    return true;

                if (i < s2.Length - patternLen + 1)
                {
                    candidateHash = RecalculateHash(s2, i - 1, i + patternLen - 1, candidateHash, patternLen);                    
                    UpdateCandidateStr(s2, patternLen, candidateEntries, i + patternLen - 1, s2[i - 1]);
                }
            }

            return false;
        }

        private bool CheckEqual(long patternHash, long candidateHash, Dictionary<char, int> patternEntries, Dictionary<char, int> candidateEntries)
        {
            return patternHash == candidateHash && CheckEqual(patternEntries, candidateEntries);
        }

        private bool CheckEqual(Dictionary<char, int> pattern, Dictionary<char, int> candidate)
        {
            return pattern.Count == candidate.Count && !pattern.Except(candidate).Any();
        }

        private static void UpdateCandidateStr(string s2, int patternLen, Dictionary<char, int> candidateEntries, int newIndex, char oldChar)
        {
            candidateEntries[oldChar]--;
            if (candidateEntries[oldChar] == 0)
                candidateEntries.Remove(oldChar);

            char newChar = s2[newIndex];
            if (candidateEntries.ContainsKey(newChar))
                candidateEntries[newChar]++;
            else
                candidateEntries.Add(newChar, 1);
        }

        // Roy's implementation of create/recalculate doesn't work, because order of the symbols in candidate/pattern strings change hash, using simplified approach intstead
        private long CreateHash(string str, int end)
        {

            //long hash = 0;
            //for (int i = 0; i < end; i++)
            //{
            //    hash += Convert.ToInt64(str[i]) * (long)Math.Pow(prime, i);
            //}

            //return hash;
            long hash = 0;
            for (int i = 0; i < end; i++)
            {
                hash += Convert.ToInt64(str[i]);
            }

            return hash;
        }

        /*
        Евгений:
        Ну можно по этому же принципу хеш составить: берешь первые 26 простых и делаешь хеш вида 
        произведение p_i^k_i где k_i количество раз которое встречается i ная буква 

        то что написал Евгений работает несомненно лучше, но вообще в самом простом виде и без доказательства будет работать следующее:

        Можно считать хешем множества сумму кубов всех элементов в нём. 
        Если возникают коллизии то еще и сумму четвертых степеней

        и в целом можно верить что всё будет хорошо.

        Конкретно данная задача и просто с суммой кубов делается, только что проверил

        */
        private long RecalculateHash(string str, int oldIndex, int newIndex, long oldHash, int patternLen)
        {
            //long newHash = oldHash - Convert.ToInt64(str[oldIndex]);
            //newHash = newHash / prime;
            //newHash += Convert.ToInt64(str[newIndex]) * (long)Math.Pow(prime, patternLen - 1);
            //return newHash;

            long newHash = oldHash - Convert.ToInt64(str[oldIndex]);
            newHash += Convert.ToInt64(str[newIndex]);

            return newHash;
        }
    }
}
