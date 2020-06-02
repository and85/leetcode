using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // the simplest implementation based on array of lists
    public class MyHashMap
    {

        //All keys and values will be in the range of[0, 1000000].
        //The number of operations will be in the range of[1, 10000].
        
            
        // trying to achieve 70% load factor (number of operation / table size)
        // table size is a prime number
        private const int TableSize = 13999;

        
        private List<KeyValuePair<int, int>>[] _buckets = new List<KeyValuePair<int, int>>[TableSize];
        
        /** Initialize your data structure here. */
        public MyHashMap()
        {

        }

        /** value will always be non-negative. */
        // O(1) for insert average case, O(n) worst case
        public void Put(int key, int value)
        {
            int bucketIndex = GetBucketIndex(key);

            // since KeyValuePair is immutable, in order to update, we need to remove the old value first
            Remove(key);

            _buckets[bucketIndex].Add(new KeyValuePair<int, int>(key, value));
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        // O(1)
        public int Get(int key)
        {
            int bucketIndex = GetBucketIndex(key);

            if (_buckets[bucketIndex] == null)
                return -1;

            var pair = _buckets[bucketIndex].SingleOrDefault(x => x.Key == key);
            // when pair doesn't exist, defualt value for KeyValuePair<int, int> contains 0 key and 0 value
            if (pair.Key == key)
                return pair.Value;

           return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        // O(1) for insert average case, O(n) worst case
        public void Remove(int key)
        {
            int bucketIndex = GetBucketIndex(key);

            var pair = _buckets[bucketIndex].SingleOrDefault(x => x.Key == key);
            // when pair doesn't exist, defualt value for KeyValuePair<int, int> contains 0 key and 0 value
            if (pair.Key == key)
                _buckets[bucketIndex].Remove(pair);
        }

        // the simplest mod merhod: 
        // https://www.geeksforgeeks.org/what-are-hash-functions-and-how-to-choose-a-good-hash-function/?ref=rp
        private int GetBucketIndex(int x)
        {
            int bucketIndex = x % TableSize;
            InitBucketLazy(bucketIndex);
 
            return bucketIndex;
        }

        private void InitBucketLazy(int bucketIndex)
        {
            if (_buckets[bucketIndex] == null)
                _buckets[bucketIndex] = new List<KeyValuePair<int, int>>();
        }
    }
}
