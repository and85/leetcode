public class Solution {
    public int MinDeletionSize(string[] strs)
    {
        int deleted = 0;

        for (int i = 0; i < strs[0].Length; i++)
        {
            if (!IsSorted(strs, i))
            {
                deleted++;
            }
        }

        return deleted;
    }

    private bool IsSorted(string[] strs, int index)
    {
        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i][index] < strs[i - 1][index]) return false;
            }

        return true;
    }
}