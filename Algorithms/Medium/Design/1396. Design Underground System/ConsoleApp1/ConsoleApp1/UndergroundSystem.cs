using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    public class UndergroundSystem
    {
        private Dictionary<string, Dictionary<int, int>> _checkIns;
        private Dictionary<string, Dictionary<int, int>> _checkOuts;

        public UndergroundSystem()
        {
            _checkIns = new Dictionary<string, Dictionary<int, int>>();
            _checkOuts = new Dictionary<string, Dictionary<int, int>>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            RecordTravelTime(id, stationName, t, _checkIns);
        }

        // TODO: Update average travel time during checkouts,
        // handle cases when the same pasanger can travel to the same station more than once
        public void CheckOut(int id, string stationName, int t)
        {
            RecordTravelTime(id, stationName, t, _checkOuts);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var checkIns = _checkIns[startStation];
            var checkOuts = _checkOuts[endStation];

            double totalTime = 0;
            int journeyCounter = 0;

            foreach (var checkOut in checkOuts)
            {
                int pasangerId = checkOut.Key;
                if (checkIns.ContainsKey(pasangerId))
                {
                    totalTime += checkOut.Value - checkIns[pasangerId];
                    journeyCounter++; 
                }
            }

            return totalTime / journeyCounter;
        }

        private void RecordTravelTime(int id, string stationName, int t, Dictionary<string, Dictionary<int, int>> travelDictionary)
        {
            if (!travelDictionary.ContainsKey(stationName))
            {
                var checkIn = new Dictionary<int, int>()
                {
                    { id, t }
                };
                travelDictionary.Add(stationName, checkIn);
            }
            else
            {
                travelDictionary[stationName].Add(id, t);
            }
        }
    }

    /**
     * Your UndergroundSystem object will be instantiated and called as such:
     * UndergroundSystem obj = new UndergroundSystem();
     * obj.CheckIn(id,stationName,t);
     * obj.CheckOut(id,stationName,t);
     * double param_3 = obj.GetAverageTime(startStation,endStation);
     */
}
