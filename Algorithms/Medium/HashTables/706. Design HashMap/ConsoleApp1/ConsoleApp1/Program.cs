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
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            hashMap.Get(1);            // returns 1
            hashMap.Get(3);            // returns -1 (not found)
            hashMap.Put(2, 1);          // update the existing value
            hashMap.Get(2);            // returns 1 
            hashMap.Remove(2);          // remove the mapping for 2
            hashMap.Get(2);            // returns -1 (not found) 

            hashMap.Remove(5);          // remove the mapping for 2
        }
    }
}
