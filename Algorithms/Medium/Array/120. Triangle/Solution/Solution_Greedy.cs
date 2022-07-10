public class Solution_Attempt1 
{
    // too slow
    public int MinimumTotal(IList<IList<int>> triangle)
    {        
        triangle = triangle.Reverse().ToList<IList<int>>();

        
        var prevRow = new Dictionary<int, List<int>>() { };
        var curRow = new Dictionary<int, List<int>>();

        var fisrtRow = triangle.First();

        for (int i = 0; i < fisrtRow.Count; i++)
        {
            prevRow.Add(i, new List<int>() { fisrtRow[i] });
        }

        int min = fisrtRow.Min();

        for (int r = 1; r < triangle.Count; r++)            
        {
            var row = triangle[r];
            min = int.MaxValue;
            curRow = new Dictionary<int, List<int>>();
            for (int i = 0; i < row.Count; i++)
            {                
                curRow.Add(i, SumWithPrevRow(prevRow, i, row[i]));              
            }

            prevRow = curRow;
        }

        return curRow?.FirstOrDefault().Value?.Min() ?? min;        
    }

    /*
    private IEnumerable<int> SumWithPrevRow(Dictionary<int, List<int>> prevRow, int index, int curV)
    {        
        if (prevRow.ContainsKey(index))
        {                     
            foreach (var p in prevRow[index])
            {
                yield return p + curV;
            }
        }
        
        if (prevRow.ContainsKey(index + 1))
        {
            foreach (var p in prevRow[index + 1])
            {
                yield return p + curV;
            }
        }        
    }
    */
    private List<int> SumWithPrevRow(Dictionary<int, List<int>> prevRow, int index, int curV)
    {
        var result = new List<int>();
        if (prevRow.ContainsKey(index))
        {            
            result.AddRange(prevRow[index].Select(p => p + curV));
        }
        
        if (prevRow.ContainsKey(index + 1))
        {
            result.AddRange(prevRow[index + 1].Select(p => p + curV));
 
        }

        return result;
    }
}