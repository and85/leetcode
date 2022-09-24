using System.Text;

public class Solution 
{
    private readonly List<char> AvailableChoices = new List<char> { 'A', 'C', 'G', 'T' };

    private HashSet<string> _genes = new HashSet<string>();
    private StringBuilder _cur = new StringBuilder();

    public int MinMutation(string start, string end, string[] bank) 
    {
        var bankSet = new HashSet<string>(bank);
        
        if (!bankSet.Contains(end)) return -1;
        if (start.Equals(end)) return 0;

        Backtrack();

        int min = int.MaxValue;
        foreach (var g in _genes)
        {
            if (g.Equals(start)) continue;
            if (!g.Equals(end)) continue;
            if (!bankSet.Contains(g)) continue;
            min = Math.Min(min, FindDifference(start, g));
        }        

        return min != int.MaxValue ? min : -1;    
    }

    private int FindDifference(string a, string b)
    {
        int diff = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                diff++;
            }
        }

        return diff;
    }

    private void Backtrack()
    {
        if (_cur.Length == 8)
        {
            if (!_genes.Contains(_cur.ToString()))           
            {
                _genes.Add(_cur.ToString());
            }            
            return;
        }

        foreach (var c in AvailableChoices)
        {
            _cur.Append(c);
            Backtrack();
            _cur.Remove(_cur.Length - 1, 1);
        }
    }
}