public class Solution 
{
    public bool HaveConflict(string[] event1, string[] event2) 
    {
        int interval1Start = ConvertToMinutes(event1[0]);
        int interval1End = ConvertToMinutes(event1[1]);
        int interval2Start = ConvertToMinutes(event2[0]);
        int interval2End = ConvertToMinutes(event2[1]);
        return (interval1Start <= interval2Start && interval2Start <= interval1End) ||
            (interval1Start <= interval2End && interval2End <= interval1End) ||
            (interval2Start <= interval1Start && interval1Start <= interval2End) ||
            (interval2Start <= interval1End && interval1End <= interval2End);
    }

    private int ConvertToMinutes(string time)
    {
        var parts = time.Split(":");
        int hours = int.Parse(parts[0]);
        int minutes = int.Parse(parts[1]);

        return hours * 60 + minutes;
    }
}