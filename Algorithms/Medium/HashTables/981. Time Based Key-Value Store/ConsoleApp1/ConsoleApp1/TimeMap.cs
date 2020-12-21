using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public class TimeMap
    {

        Dictionary<string, SortedList<int, string>> _store;
        public TimeMap()
        {
            _store = new Dictionary<string, SortedList<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (_store.ContainsKey(key))
            {
                _store[key].Add(timestamp, value);
            }
            else
            {
                var list = new SortedList<int, string>();
                list.Add(timestamp, value);
                _store.Add(key, list);
            }
        }

        public string Get(string key, int timestamp)
        {
            if (!_store.ContainsKey(key))
                return string.Empty;

            var values = _store[key];

            int low = 0;
            int high = values.Count;
            int median = 0;
            while (low < high)
            {
                median = (high - low) / 2 + low;

                if (timestamp == values.Keys[median])
                {
                    return values.Values[median];
                }

                if (timestamp > values.Keys[median])
                    low = median + 1;
                if (timestamp < values.Keys[median])
                    high = median - 1;
            }

            if (high < 0)
                return string.Empty;

            int medianTmsp = values.Keys[median] <= timestamp ? values.Keys[median] : 0;
            int highTmsp = high < values.Count && values.Keys[high] <= timestamp ? values.Keys[high] : 0;
            
            if (medianTmsp == 0 && highTmsp == 0)
                return string.Empty;

            if (highTmsp > medianTmsp)
                return values.Values[high];

            if (medianTmsp > highTmsp)
                return values.Values[median];

            return string.Empty;
        }
    }

    /**
    * Your TimeMap object will be instantiated and called as such:
    * TimeMap obj = new TimeMap();
    * obj.Set(key,value,timestamp);
    * string param_2 = obj.Get(key,timestamp);
    */
}
