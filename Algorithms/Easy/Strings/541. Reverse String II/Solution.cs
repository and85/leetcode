public class Solution 
{
    public string ReverseStr(string s, int k) 
    {
        if (string.IsNullOrEmpty(s))
            return s;

        var arr = s.ToCharArray();
        
        int fp = 0, sp;
        while (fp < s.Length)
        {
            sp = GetSecondPointer(fp, k, s.Length);
            ReverseStr(arr, fp, sp);
            fp += 2*k;
        }


        return new string(arr);
    }

    private void ReverseStr(char[] arr, int fp, int sp)
    {
        char t;
        while (fp < sp)
        {
            t = arr[fp];
            arr[fp] = arr[sp];
            arr[sp] = t;
            fp++;
            sp--;
        }
    }

    private int GetSecondPointer(int i, int k, int length)
    {
        int pos = i + k - 1;
        return pos < length ? pos : length - 1;
    }
}