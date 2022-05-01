public class Solution {
    public int FindContentChildren(int[] g, int[] s) {

        /*
        1, 2, 3, 4, 5, 6

        1, 1, 5
        */
        Array.Sort(g);
        Array.Sort(s);

        int result = 0;

        for (int i = 0, j = 0; i < g.Length && j < s.Length; i++, j++)
        {
            int k = j;
            for (; k < s.Length; k++)
            {
                if (s[k] >= g[i])
                {
                    result++;
                    j = k;
                    break;
                }     
            }
            j = k;
        }

        return result;
    }
}