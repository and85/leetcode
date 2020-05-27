using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyHashMap
    {

        //All keys and values will be in the range of[0, 1000000].
        //The number of operations will be in the range of[1, 10000].

        // trying to achieve 70% load factor 
        private List<int>[] _buckets = new List<int>[14000];
        
        /** Initialize your data structure here. */
        public MyHashMap()
        {

        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {

        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return 0;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {

        }
    }
}
