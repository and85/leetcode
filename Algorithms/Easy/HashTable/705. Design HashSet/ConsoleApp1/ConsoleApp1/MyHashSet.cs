using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyHashSet
    {
        private const int BucketsNum = 100000;
        private List<int>[] _storage;


        /** Initialize your data structure here. */
        public MyHashSet()
        {
            _storage = new List<int>[BucketsNum];
            for (int i = 0; i < BucketsNum; i++)
                _storage[i] = new List<int>();
        }

        public void Add(int key)
        {
            int index = GetBucketIndex(key);
            
            if (!_storage[index].Contains(key))
                _storage[index].Add(key);
        }

        public void Remove(int key)
        {
            int index = GetBucketIndex(key);
            _storage[index].Remove(key);
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int index = GetBucketIndex(key);
            return _storage[index].Contains(key);
        }

        private int GetHashCode(int key)
        {
            int hash = 17;
            hash = hash * 31 + key.GetHashCode();

            return hash;
        }

        private int GetBucketIndex(int key)
        {
            return GetHashCode(key) % BucketsNum;
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}
