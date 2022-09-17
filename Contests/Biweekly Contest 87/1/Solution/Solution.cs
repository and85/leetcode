using System.Globalization;

public class Solution {
    public int CountDaysTogether(string arriveAlice, 
    
        string leaveAlice, 
        string arriveBob, 
        string leaveBob) 
    {
        var arriveAliceDt = DateTime.ParseExact(arriveAlice + "-2022", "MM-dd-yyyy",null);
        var leaveAliceDt = DateTime.ParseExact(leaveAlice + "-2022", "MM-dd-yyyy", null);
        var arriveBobDt = DateTime.ParseExact(arriveBob + "-2022", "MM-dd-yyyy", null);
        var leaveBobDt = DateTime.ParseExact(leaveBob + "-2022", "MM-dd-yyyy", null);

        int maxArrive = Math.Max(arriveAliceDt.DayOfYear, arriveBobDt.DayOfYear);
        int minLeave = Math.Min(leaveAliceDt.DayOfYear, leaveBobDt.DayOfYear);

        if (minLeave >= maxArrive)
        {
            return minLeave - maxArrive + 1;
        }

        return 0;
    }
}