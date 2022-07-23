public class Solution 
{
    public int RangeBitwiseAnd(int left, int right) 
    {        
        var ones = new HashSet<int>();      
        int size = sizeof(int) * 8;

        for (int i = 0; i < size; i++)
        {
            ones.Add(i);
        }

        for (int num = left; num <= right; num++)
        {
            if (ones.Count == 0) break;


            foreach (int digit in ones)
            {                
                if (GetBit(num, digit) == 0)
                {
                    ones.Remove(digit);
                }
            }
        }

        int res = 0;
        foreach (int digit in ones)
        {
            res = SetBit(res, digit);
        }

        return res;
    }

    public int RangeBitwiseAnd_Slow(int left, int right) 
    {
        int res = 0;

        for (int i = 0; i < sizeof(int) * 8; i++)
        {
            bool zeroFound = false;
            for (int num = left; num <= right; num++)
            {
                if (GetBit(num, i) == 0)
                {
                    zeroFound = true;
                    break;
                }
            }

            if (zeroFound)
            {
                res = ResetBit(res, i);
            }
            else
            {
                res = SetBit(res, i);
            }

        }

        return res;
    }

    public int ResetBit(int num, int index)
    {
        return num &= ~(1 << index);
    }

    public int SetBit(int num, int index)
    {
        return num |= 1 << index;
    }

    public int GetBit(int num, int index)
    {        
        return (num >> index) & 1;
    }
}