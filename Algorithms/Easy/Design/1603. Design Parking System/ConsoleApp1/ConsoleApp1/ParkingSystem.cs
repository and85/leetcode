using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParkingSystem
    {

        Dictionary<int, int> _slots = new Dictionary<int, int>();

        public ParkingSystem(int big, int medium, int small)
        {
            _slots.Add(1, big);
            _slots.Add(2, medium);
            _slots.Add(3, small);
        }

        public bool AddCar(int carType)
        {
            if (_slots[carType] == 0) return false;
            _slots[carType]--;
            
            return true;
        }
    }
}
