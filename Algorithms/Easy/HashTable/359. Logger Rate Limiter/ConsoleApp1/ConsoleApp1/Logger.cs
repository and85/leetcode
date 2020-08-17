using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Logger
    {
        private Dictionary<string, int> _storage; 

        public Logger()
        {
            _storage = new Dictionary<string, int>();
        }

        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
        If this method returns false, the message will not be printed.
        The timestamp is in seconds granularity. */
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (_storage.ContainsKey(message))
            {
                if (timestamp - _storage[message] < 10)
                    return false;
                else 
                    _storage[message] = timestamp;
            }
            else
            {
                _storage.Add(message, timestamp);
            }

            return true;
        }
    }
}
