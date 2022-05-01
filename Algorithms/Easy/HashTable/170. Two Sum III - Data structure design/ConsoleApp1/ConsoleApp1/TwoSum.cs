using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TwoSum
    {

        private Dictionary<int, List<int>> _set = new Dictionary<int, List<int>>();
        private int _counter = 0;

        public TwoSum()
        {

        }

        public void Add(int number)
        {                                    
            if (!_set.ContainsKey(number))
            {
                _set.Add(number, new List<int>() { _counter++ });
            }
            else
            {
                _set[number].Add(_counter++);
            }
            
        }

        public bool Find(int value)
        {            
            foreach (var num in _set)
            {
                int target = value - num.Key;
                if (_set.ContainsKey(target))
                {
                    foreach (var n in num.Value)
                    {
                        if (_set[target].Any(v => v != n)) return true;
                    }
                }
            }

            return false;
        }
    }
}
