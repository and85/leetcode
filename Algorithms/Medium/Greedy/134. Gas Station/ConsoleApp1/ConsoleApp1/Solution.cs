using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _stationCount;
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            _stationCount = gas.Length;

            for (int station = 0; station < _stationCount; station++)
            {
                if (CanTravelFromStation(station, gas, cost))
                    return station;
            }

            return -1;
        }

        private bool CanTravelFromStation(int target, int[] gas, int[] cost)
        {
            int cur = target;
            int tank = 0;

            do
            {
                tank = FillTank(gas, cur, tank);

                if (!HaveEnoughFuel(cost, cur, tank))
                    return false;

                MoveToNextStation(cost, ref cur, ref tank);
            }
            while (cur != target);

            return true;
        }

        private int FillTank(int[] gas, int cur, int tank)
        {
            tank += gas[cur];
            return tank;
        }

        private void MoveToNextStation(int[] cost, ref int cur, ref int tank)
        {
            tank -= cost[cur];
            cur = GetNextStation(cur);
        }

        private bool HaveEnoughFuel(int[] cost, int cur, int tank)
        {
            return tank >= cost[cur];
        }

        private int GetNextStation(int station)
        {
            int nextStation = station + 1;
            return nextStation < _stationCount ? nextStation : 0;
        }
    }
}
