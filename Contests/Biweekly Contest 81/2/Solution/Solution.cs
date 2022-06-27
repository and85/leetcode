public class Solution 
{        

    public long CountPairs(int n, int[][] edges) 
    {
        var uf = new QuickUnionUF(n);

        foreach(var edge in edges)
        {
            uf.Uunion(edge[0], edge[1]);
        }


        var components = new Dictionary<int, long>();        
        for (int i = 0; i < n; i++)
        {
            int parent = uf.Find(i);    
            if (components.ContainsKey(parent))
            {
                components[parent]++;
            }
            else
            {
                components.Add(parent, 1);
            }
        }                

        long result = 0;
        long left = n;
        foreach (var component in components)
        {
            left -= component.Value;
            result += component.Value * left;
        }

        return result;
    }    

    public class QuickUnionUF
    {
        private Dictionary<int, int> _cache = new Dictionary<int, int>();

        private int[] _parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Number of unique elements</param>
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
            //if (_cache.ContainsKey(p))
              //  return _cache[p];

            Validate(p);

            while (p != _parent[p])
            {
                p = _parent[p];
            }

            //_cache.Add(p, p);
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
}