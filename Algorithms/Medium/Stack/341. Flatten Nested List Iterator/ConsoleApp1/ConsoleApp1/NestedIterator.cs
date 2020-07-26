using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class NestedIterator
    {

        private Queue<int> _integers = new Queue<int>();

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            FlattenList(nestedList);
        }

        private void FlattenList(IList<NestedInteger> nestedList)
        {
            foreach (var integer in nestedList)
            {
                if (integer.IsInteger())
                    _integers.Enqueue(integer.GetInteger());
                else
                {
                    FlattenList(integer.GetList());
                }
            }
        }

        public bool HasNext()
        {
            return _integers.Count > 0;
        }

        public int Next()
        {
            return _integers.Dequeue();
        }
    }
}
