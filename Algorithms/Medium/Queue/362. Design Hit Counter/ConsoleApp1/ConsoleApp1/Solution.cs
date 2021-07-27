using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HitCounter
    {
        private Queue<int> _timestamps;

        /** Initialize your data structure here. */
        public HitCounter()
        {
            _timestamps = new Queue<int>();
        }

        /** Record a hit.
            @param timestamp - The current timestamp (in seconds granularity). */
        public void Hit(int timestamp)
        {
            _timestamps.Enqueue(timestamp);
        }

        /** Return the number of hits in the past 5 minutes.
            @param timestamp - The current timestamp (in seconds granularity). */
        public int GetHits(int timestamp)
        {
            while (_timestamps.Count > 0)
            {
                if (timestamp - _timestamps.Peek() < 300) 
                    break;
                _timestamps.Dequeue();
            }


            return _timestamps.Count;
        }
    }

    /**
     * Your HitCounter object will be instantiated and called as such:
     * HitCounter obj = new HitCounter();
     * obj.Hit(timestamp);
     * int param_2 = obj.GetHits(timestamp);
     */
}
