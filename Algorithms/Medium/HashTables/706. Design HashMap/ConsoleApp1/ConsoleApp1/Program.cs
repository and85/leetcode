using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMap hashMap = new MyHashMap();
            hashMap.put(1, 1);
            hashMap.put(2, 2);
            hashMap.get(1);            // returns 1
            hashMap.get(3);            // returns -1 (not found)
            hashMap.put(2, 1);          // update the existing value
            hashMap.get(2);            // returns 1 
            hashMap.remove(2);          // remove the mapping for 2
            hashMap.get(2);            // returns -1 (not found) 
        }
    }
}
