using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            // we need to have stable sort, by default Array.Sort is not stable
            // so we need to either use stable OrderBy from linq or stabilize Array.Sort method
            
            // approach 1
            return logs.OrderBy(s => s, new LogComparer()).ToArray();
            
            // approach 2
            // return StableSort(logs, new LogComparer()).ToArray();
        }
        public class LogComparer : IComparer<string>
        {
            const string Space = " ";

            public int Compare(string x, string y)
            {
                bool xIsDigitLog = IsDigitLog(x);
                bool yIsDigitLog = IsDigitLog(y);

                if (xIsDigitLog && yIsDigitLog)
                    return 0;

                if (!xIsDigitLog && yIsDigitLog)
                    return -1;

                if (xIsDigitLog && !yIsDigitLog)
                    return 1;

                if (!xIsDigitLog && !yIsDigitLog)
                    return CompareLetterLogs(x, y);

                return 0;
            }

            private bool IsDigitLog(string xStr)
            {
                string xValue = GetLogString(xStr);

                return xValue.All(c => Char.IsDigit(c) || Char.IsWhiteSpace(c));
            }

            private int CompareLetterLogs(string xStr, string yStr)
            {
                string xValue = GetLogString(xStr);
                string yValue = GetLogString(yStr);

                int comparisonResult = xValue.CompareTo(yValue);

                if (comparisonResult == 0)
                {
                    string xIdentifier = GetLogIdentifier(xStr);
                    string yIdentifier = GetLogIdentifier(yStr);

                    return xIdentifier.CompareTo(yIdentifier);
                }

                return comparisonResult;
            }

            private static string GetLogIdentifier(string xStr)
            {
                int xIndex = xStr.IndexOf(Space);
                string xIdentifier = xStr.Substring(0, xIndex);

                return xIdentifier;
            }

            private static string GetLogString(string xStr)
            {
                int xIndex = xStr.IndexOf(Space);
                string xValue = xStr.Substring(xIndex + 1);

                return xValue;
            }
        }

        public string[] StableSort(string[] values, IComparer<string> comparer)
        {
            var keys = new KeyValuePair<int, string>[values.Length];
            for (var i = 0; i < values.Length; i++)
                keys[i] = new KeyValuePair<int, string>(i, values[i]);
            Array.Sort(keys, values, new StabilizingComparer<string>(comparer));

            return values;
        }

        private sealed class StabilizingComparer<T> : IComparer<KeyValuePair<int, T>>
        {
            private readonly IComparer<T> _comparer;

            public StabilizingComparer(IComparer<T> comparer)
            {
                _comparer = comparer;
            }

            public int Compare(KeyValuePair<int, T> x,
                               KeyValuePair<int, T> y)
            {
                var result = _comparer.Compare(x.Value, y.Value);
                return result != 0 ? result : x.Key.CompareTo(y.Key);
            }
        }
    }
}
