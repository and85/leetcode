public class Solution 
{
    public long TaskSchedulerII(int[] tasks, int space) 
    {
        long days = 0;
        int curTask = 0;
        var completedTasks = new Dictionary<int, long>();

        int task = tasks[curTask];
        while(curTask < tasks.Length)
        {            
            if (CanComplete(task, completedTasks, space, days))
            {
                completedTasks[task] = days;
                curTask++;

                if (curTask < tasks.Length)
                {
                    task = tasks[curTask];
                }
            }
            else
            {
                days = completedTasks[task] + space;
            }

            days++;
        }

        return days;
    }

    private bool CanComplete(int task, Dictionary<int, long> completedTasks, int space, long curDay)
    {
        if (!completedTasks.ContainsKey(task))
        {
            return true;
        }

        return curDay - completedTasks[task] > space;
    }
}