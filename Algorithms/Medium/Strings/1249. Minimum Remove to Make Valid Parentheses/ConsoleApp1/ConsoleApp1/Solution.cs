using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private const char OpenBracket = '(';
        private const char ClosedBracket = ')';

        class Bracket
        {
            public Bracket(char symbol, int index)
            {
                Symbol = symbol;
                Index = index;
            }

            public char Symbol { get; set; }
            public int Index { get; set; }
        }

        public string MinRemoveToMakeValid(string s)
        {
            var invalidStack = GetInvalidBrackets(s);
            var invalidIndexes = GetInvalidIndexes(invalidStack);

            return BuildValidString(s, invalidIndexes);
        }

        private string BuildValidString(string s, HashSet<int> invalidIndexes)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!invalidIndexes.Contains(i))
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }

        private HashSet<int> GetInvalidIndexes(Stack<Bracket> invalidStack)
        {
            var invalidIndexes = new HashSet<int>();
            while (invalidStack.Count > 0)
            {
                var invalidBracket = invalidStack.Pop();
                invalidIndexes.Add(invalidBracket.Index);
            }

            return invalidIndexes;
        }

        private Stack<Bracket> GetInvalidBrackets(string s)
        {
            var invalidStack = new Stack<Bracket>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == OpenBracket)
                {
                    invalidStack.Push(new Bracket(s[i], i));
                    continue;
                }

                if (s[i] == ClosedBracket)
                {
                    if (invalidStack.TryPeek(out var peek))
                    {
                        if (peek.Symbol == OpenBracket)
                        {
                            invalidStack.Pop();
                            continue;
                        }
                    }

                    invalidStack.Push(new Bracket(s[i], i));
                    continue;
                }
            }

            return invalidStack;
        }
    }
}
