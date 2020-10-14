using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LRUCache
    {
        private Dictionary<int, int> _cache = new Dictionary<int, int>();
        private Dictionary<int, int> _usage = new Dictionary<int, int>();

        private int _capacity;
        private int _usageCounter = 0;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.ContainsKey(key))
            {
                UpdateKeyUsage(key);
                return _cache[key];
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (!_cache.ContainsKey(key) && _cache.Count == _capacity)
            {
                RemoveLeastRecentlyUsedElement();
            }

            UpdateKeyUsage(key);
            _cache[key] = value;
        }

        private void RemoveLeastRecentlyUsedElement()
        {
            int leastUsage = _usage.Min(u => u.Value);
            int leastKey = _usage.Single(u => u.Value == leastUsage).Key;

            _usage.Remove(leastKey);
            _cache.Remove(leastKey);
        }

        private void UpdateKeyUsage(int key)
        {
            _usageCounter++;
            _usage[key] = _usageCounter;
        }
    }
}
