using System.Linq;

public class Solution
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        var tg = target.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var ag = arr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        foreach (var t in tg)
        {
            if (!ag.ContainsKey(t.Key)) return false;
            if (ag[t.Key] != t.Value) return false;
        }

        foreach (var a in ag)
        {
            if (!tg.ContainsKey(a.Key)) return false;
            if (tg[a.Key] != a.Value) return false;
        }

        return true;
    }
}