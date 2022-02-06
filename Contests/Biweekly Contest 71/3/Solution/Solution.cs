public class Solution
{
    public int MinCostSetTime(int startAt, int moveCost, int pushCost, int targetSeconds)
    {
        int minutes = targetSeconds / 60;        

        int seconds = targetSeconds % 60;

        if (minutes > 99)
        {
            minutes = minutes - 1;
            seconds = seconds + 60;
        }

        List<string> options = new List<string>();
        string option1 = minutes.ToString() + (seconds < 10 ? "0" + seconds.ToString() : seconds.ToString());
        options.Add(option1.TrimStart('0'));

        if (seconds <= 39  && minutes > 0)
        {
            seconds += 60;
            string option2 = (minutes - 1).ToString() + seconds.ToString();
            options.Add(option2.TrimStart('0'));
        }

        if (targetSeconds <= 99)
        {
            string option3 = targetSeconds.ToString();
            options.Add(option3.TrimStart('0'));
        }

        int minCost = FindMinCost(startAt, moveCost, pushCost, options);


        return minCost;
    }

    private int FindMinCost(int startAt, int moveCost, int pushCost, List<string> options)
    {
        int minCost = int.MaxValue;
        int curCost = 0;


        foreach (string option in options)
        {

            var hashSet = GetUniqueSymbols(option);

            curCost = option.Length * pushCost;
            curCost += hashSet.Count * moveCost - (hashSet.Contains(startAt) ? moveCost : 0);

            minCost = Math.Min(curCost, minCost);
        }

        return minCost;
    }

    private HashSet<int> GetUniqueSymbols(string option)
    {
        var hashSet = new HashSet<int>();

        for (int i = 0; i < option.Length; i++)
        {
            if (hashSet.Contains(option[i] - '0'))
            {
                continue;
            }

            hashSet.Add(option[i] - '0');
        }

        return hashSet;
    }
}