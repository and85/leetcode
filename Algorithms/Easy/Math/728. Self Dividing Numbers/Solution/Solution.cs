public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        var result = new List<int>();
        for (int i = left; i <= right; i++)
        {
            if (SelfDividingNumber(i))
            {
                result.Add(i);
            } 
        }

        return result;
    }

    private bool SelfDividingNumber(int num)
    {
        int original = num;
        while (num > 0)
        { 
            int d = num % 10;
            if (d == 0 || original % d != 0) return false;
            num = num / 10;
        }

        return true;
    }
}