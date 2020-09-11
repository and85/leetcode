using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    public class UndergroundSystem
    {
        public class AverageTravelTime
        {
            public AverageTravelTime(int totalTravelTime, int journeyCounter)
            {
                TotalTravelTime = totalTravelTime;
                JourneyCounter = journeyCounter;
            }

            public int TotalTravelTime { get; set; }

            public int JourneyCounter { get; set; }
        }

        public class StationCheckIn
        {
            public StationCheckIn(string startStation, int time)
            {
                StartStation = startStation;
                Time = time;
            }

            public string StartStation { get; set; }
            public int Time { get; set; }
        }

        private Dictionary<string, AverageTravelTime> _journeys = new Dictionary<string, AverageTravelTime>();

        private Dictionary<int, StationCheckIn> _checkIns = new Dictionary<int, StationCheckIn>();

        public UndergroundSystem()
        {
        }

        public void CheckIn(int id, string stationName, int t)
        {
            _checkIns.Add(id, new StationCheckIn(stationName, t));
        }

        // TODO: Update average travel time during checkouts,
        // handle cases when the same pasanger can travel to the same station more than once
        public void CheckOut(int id, string stationName, int t)
        {
            StationCheckIn checkIn = _checkIns[id];
            string key = GetJourneyKey(checkIn.StartStation, stationName);
            int travelTime = t - checkIn.Time;

            if (_journeys.ContainsKey(key))
            {
                var averageTravelTime = _journeys[key];
                averageTravelTime.TotalTravelTime += travelTime;
                averageTravelTime.JourneyCounter++;

                _journeys[key] = averageTravelTime;
            }
            else
            {
                var averageTravelTime = new AverageTravelTime(travelTime, 1);
                _journeys.Add(key, averageTravelTime);
            }

            _checkIns.Remove(id);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            string key = GetJourneyKey(startStation, endStation);
            var journey = _journeys[key];

            return (double)journey.TotalTravelTime / journey.JourneyCounter;
        }

        private string GetJourneyKey(string startStation, string endStation)
        {
            return $"{startStation}:{endStation}";
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
