using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RandomizedSet
    {
        private int _setCounter = 0;
        private Dictionary<int, int> _dict = new Dictionary<int, int>();
        private List<int> _list = new List<int>();
        private Random _random = new Random();

        /** Initialize your data structure here. */
        public RandomizedSet()
        {

        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (_dict.ContainsKey(val))
                return false;

            _dict.Add(val, _setCounter);
            _list.Add(val);
            _setCounter++;

            return true;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!_dict.ContainsKey(val))
                return false;

            int removedIndex = _dict[val];
            int lastIndex = _setCounter - 1;
            SwapWithLastElement(removedIndex, lastIndex);

            _dict.Remove(val);
            _list.RemoveAt(lastIndex);

            _setCounter--;

            return true;
        }

        private void SwapWithLastElement(int removedIndex, int lastIndex)
        {
            int lastElement = _list[lastIndex];
            _list[removedIndex] = lastElement;
            _dict[lastElement] = removedIndex;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            int randomIndex = _random.Next(0, _setCounter - 1);
            return _list[randomIndex];
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
