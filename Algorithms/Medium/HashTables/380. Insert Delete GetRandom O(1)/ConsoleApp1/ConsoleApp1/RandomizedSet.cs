using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RandomizedSet
    {
        // 
        private Dictionary<long, int> _map = new Dictionary<long, int>();
        private List<long> _values = new List<long>(); 

        /** Initialize your data structure here. */
        public RandomizedSet()
        {

        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (_map.ContainsKey(val))
            {
                if (_map[val] == int.MinValue)
                {
                    _map[val] = 
                }

                return false;
            }

            _map.Add(val, _values.Count);
            _values.Add(val);

            return true;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            //if (!_map.ContainsKey(val))
            //    return false;

            //var index = _map[val];
            //_values.RemoveAt(index);

            return true;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return 0;
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
