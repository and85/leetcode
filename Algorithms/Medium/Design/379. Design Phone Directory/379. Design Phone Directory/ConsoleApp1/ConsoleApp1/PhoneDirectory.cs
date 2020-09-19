using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class PhoneDirectory
    {
        private HashSet<int> _availableNumbers = new HashSet<int>();


        /** Initialize your data structure here
            @param maxNumbers - The maximum numbers that can be stored in the phone directory. */
        public PhoneDirectory(int maxNumbers)
        {
            for (int i = 0; i < maxNumbers; i++)
                _availableNumbers.Add(i);
        }

        /** Provide a number which is not assigned to anyone.
            @return - Return an available number. Return -1 if none is available. */
        public int Get()
        {
            if (_availableNumbers.Count == 0)
                return -1;
            int availableNumber = _availableNumbers.First();
            _availableNumbers.Remove(availableNumber);

            return availableNumber;
        }

        /** Check if a number is available or not. */
        public bool Check(int number)
        {
            return _availableNumbers.Contains(number);
        }

        /** Recycle or release a number. */
        public void Release(int number)
        {
            _availableNumbers.Add(number);
        }
    }

}
