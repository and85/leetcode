public class Solution 
{
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) 
    {
        IList<IList<int>> result = new List<IList<int>>();

        var dict1 = new Dictionary<int, int>();
        for (int i = 0; i < items1.Length; i++)
        {
            dict1.Add(items1[i][0], items1[i][1]);
        }

        var dict2 = new Dictionary<int, int>();
        for (int i = 0; i < items2.Length; i++)
        {
            dict2.Add(items2[i][0], items2[i][1]);
        }

        foreach (var item in dict1)
        {
            int sv = 0;
            if (dict2.ContainsKey(item.Key))
            {
                sv = dict2[item.Key];
            }

            result.Add(new List<int>() { item.Key, item.Value + sv });
        }

        foreach (var item in dict2)
        {            
            if (!dict1.ContainsKey(item.Key))
            {
                result.Add(new List<int>() { item.Key, item.Value} );
            }            
        }

        return result.OrderBy(l => l.First()).ToList();
    }
}