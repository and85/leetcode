using System;
using System.Collections.Generic;

public class Solution 
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        if (intervals.Length == 0) return true;

        var heap = BuildHeap(intervals);

        int[] prev = heap.Dequeue();
        while (heap.Count > 0)
        {
            int[] interval = heap.Dequeue();
            if (prev[1] > interval[0]) return false;

            prev = interval;
        }

        return true;
    }

    private static PriorityQueue<int[], int> BuildHeap(int[][] intervals)
    {
        var heap = new PriorityQueue<int[], int>();
        for (int i = 0; i < intervals.Length; i++)
        {
            heap.Enqueue(intervals[i], intervals[i][0]);
        }

        return heap;
    }
}