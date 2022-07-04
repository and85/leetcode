using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Solution 
{    
    class Comparer : IEqualityComparer<StringBuilder>
    {
        public bool Equals(StringBuilder? x, StringBuilder? y)
        {            
            return x.Equals(y);
        }

        public int GetHashCode(StringBuilder obj)
        {
            int hash = 0;
            //return obj.GetHashCode();
            for (int i = 0; i < obj.Length; i++)
            {
                hash += obj[i];
            }

            return hash;
        }
    }
    
    private HashSet<StringBuilder> _result = new HashSet<StringBuilder>(new Comparer());

    public IList<string> LetterCasePermutation(string s) 
    {        
        var sb = new StringBuilder(s);
        Backtrack(0, sb);
        return _result.Select(sb => sb.ToString()).ToList();
    }

    private void Backtrack(int first, StringBuilder sb)
    {        
        if (!_result.Contains(sb))
        {            
            var newSb = new StringBuilder(sb.Length);
            newSb.Append(sb);
            _result.Add(newSb);            
        }
        else
        {
            return;
        }                

        for (int i = first; i < sb.Length; i++)
        {
            if (char.IsLetter(sb[i]))
            {
                ReplaceChar(sb, i);

                Backtrack(first + 1, sb);

                ReplaceChar(sb, i);
            }
        }
    }

    private void ReplaceChar(StringBuilder sb, int i)
    {
        if (char.IsLower(sb[i]))
        {
            ReplaceCharByUpper(sb, i);
        }
        else if (char.IsUpper(sb[i]))
        {
            ReplaceCharByLower(sb, i);
        }        
    }

    private void ReplaceCharByUpper(StringBuilder sb, int i)
    {        
        sb[i] = char.ToUpper(sb[i]);        
    }

    private void ReplaceCharByLower(StringBuilder sb, int i)
    {        
        sb[i] = char.ToLower(sb[i]);        
    }
}