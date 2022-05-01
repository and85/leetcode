public class Solution {
    public int MinSetSize(int[] arr) {
        var counts = arr
            .GroupBy(e => e)
            .Select(e => e.Count())
            .OrderByDescending(c => c);

        int result = 0;
        int total = 0;
        foreach (var item in counts)
        {
            result++;
            total += item;
            if (total <= arr.Length / 2)
                break;
        }

        return result;
    }
}