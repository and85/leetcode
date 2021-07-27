using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        // taken from coursera: https://www.coursera.org/learn/algorithms-part1/lecture/ZgecU/quick-union
        public class QuickUnionUF
        {
            private int[] _parent;

            public QuickUnionUF(int n)
            {
                _parent = new int[n];
                Count = n;

                for (int i = 0; i < n; _parent[i] = i++)
                {
                }

            }

            public int Count { get; set; }

            // returns component number where p is located
            public int Find(int p)
            {
                Validate(p);

                while (p != _parent[p])
                {
                    p = _parent[p];
                }

                return p;
            }

            private void Validate(int p)
            {
                int n = _parent.Length;
                if (p < 0 || p >= n)
                {
                    throw new ArgumentException("index " + p + " is not between 0 and " + (n - 1));
                }
            }

            public void Uunion(int p, int q)
            {
                int rootP = Find(p);
                int rootQ = Find(q);
                if (rootP != rootQ)
                {
                    _parent[rootP] = rootQ;
                    Count--;
                }
            }
        }


        public int MakeConnected(int n, int[][] connections)
        {
            if (connections.Length < n - 1) return -1;

            QuickUnionUF uf = new QuickUnionUF(n);

            int p;
            int q;
            for (int i = 0; i < connections.Length; i++)
            {
                p = connections[i][0];
                q = connections[i][1];
                if (uf.Find(p) != uf.Find(q))
                {
                    uf.Uunion(p, q);
                }
            }

            int requiredEdges = uf.Count - 1;

            return requiredEdges;
        }
    }
}
