using System.Text;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var sb = new StringBuilder(strs[0]);

        for (int i = 1; i < strs.Length; i++)
        {
            if (sb.Length == 0) break;
            
            int min = Math.Min(sb.Length, strs[i].Length);
            int end = min - 1;
            for (int j = 0; j < min; j++)
            {
                if (sb[j] != strs[i][j])
                {
                    end = j;
                    break;
                }
            }

            sb.Remove(end, sb.Length - end);

        }

        return sb.ToString();
    }
}