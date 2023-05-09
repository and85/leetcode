public class Solution {
    public int MinimumRecolors(string blocks, int k) 
    {
        int min = int.MaxValue;
        
        int w = 0, b = 0;
        for (int i = 0; i < k; i++)
        {
            if (blocks[i] == 'W') 
            {
                w++;
            }
            else
            {
                b++;
            }
        }

        min = Math.Min(w, min);
        if (min == 0) return 0;

        for (int i = k; i < blocks.Length; i++)
        {
            if (blocks[i] == 'W')
            {
                w++;
            }
            else
            {
                b++;
            }
            
            if (blocks[i - k] == 'W')
            {
                w--;
            }
            else
            {
                b--;
            }

            min = Math.Min(w, min);
            if (min == 0) return 0;
        }
        
        return min;
    }
}