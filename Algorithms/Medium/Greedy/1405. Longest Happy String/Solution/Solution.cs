using System.Text;

public class Solution {
    public string LongestDiverseString(int a, int b, int c) 
    {
        var sb = new StringBuilder();
        
        while (GetEligibleCharacter(a, b, c, out var ch, sb))
        {
            switch (ch)
            {
                case 'a':
                    a--;
                    break;
                case 'b':
                    b--;
                    break;
                case 'c':
                    c--;
                    break;
            }

            sb.Append(ch);
        }

        return sb.ToString();
    }

    private bool GetEligibleCharacter(int a, int b, int c, out char ch, StringBuilder sb)
    {
        ch = '0';
        if (sb.Length >= 2)       
        {
            if (sb[sb.Length - 1] == 'a' &&  sb[sb.Length - 2] == 'a')
            {
                a = 0;
            }

            if (sb[sb.Length - 1] == 'b' &&  sb[sb.Length - 2] == 'b')
            {
                b = 0;
            }

            if (sb[sb.Length - 1] == 'c' &&  sb[sb.Length - 2] == 'c')
            {
                c = 0;
            }
        }

        int max = Math.Max(Math.Max(a, b), c);

        if (a == max)
        {
            ch = 'a';
        }
        else if (b == max)
        {
            ch = 'b';
        }
        else if (c == max)
        {
            ch = 'c';
        }

        return max > 0;
    }
}