﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private IList<IList<int>> _result = new List<IList<int>>();
        private IList<int> _current = new List<int>();

        public IList<IList<int>> Combine(int n, int k)
        {
            Backtrack(n, k, 1);

            return _result;
        }

        private void Backtrack(int n, int k, int first)
        {
            if (_current.Count == k)
            {
                _result.Add(_current.ToList());
                return;
            }

            for (int i = first; i <= n; i++)
            {
                _current.Add(i);
                Backtrack(n, k, i + 1);
                _current.Remove(i);
            }
        }
    }
}
