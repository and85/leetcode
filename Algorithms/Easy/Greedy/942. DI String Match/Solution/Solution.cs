public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int N = s.Length;
        int lo = 0, hi = N;
        int[] ans = new int[N + 1];
        for (int i = 0; i < N; ++i) {
        if (s[i] == 'I')
            ans[i] = lo++;
        else
            ans[i] = hi--;
        }

        ans[N] = lo;
        return ans;
    }

    public int[] DiStringMatch_Attempt1(string s)
    {
        int[] result = new int[s.Length + 1];
        int firstPosition = s.ToCharArray().Where(c => c == 'D').Count();
        int cur = 0;
        result[0] = firstPosition;
        var taken = new HashSet<int>();
        taken.Add(firstPosition);


        int prev = firstPosition;
        foreach (var c in s)
        {
            int el;
            if (c == 'I')
            {
                el = FindMinFromGreater(taken, prev, s.Length);
            }
            else
            {
                el = FindMaxFromSmaller(taken, prev);
            }
            taken.Add(el);
            result[++cur] = el;
            prev = el;
        }

        return result;
    }

    public int FindMaxFromSmaller(HashSet<int> set, int prev)
    {
        for (int i = prev - 1; i >= 0; i--)
        {
            if (set.Contains(i)) continue;
            return i;
        }

        return -1;
    }

    public int FindMinFromGreater(HashSet<int> set, int prev, int max)
    {
        for (int i = prev + 1; i <= max; i++)
        {
            if (set.Contains(i)) continue;
            return i;
        }

        return -1;
    }
}