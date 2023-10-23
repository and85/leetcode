using System.Text;

public class Solution
{
    public static string ReverseWordOrder(string str)  
    {
        // O(n) time, O(n) space 
        var sb = new StringBuilder();
        var buffer = new StringBuilder();
        for (int i = str.Length - 1; i >= -1; i--)
        {
            if (i == -1 || str[i] == ' ')
            {
                var b = buffer.ToString().ToCharArray().Reverse().ToArray();
                sb.Append(new string(b));
                sb.Append(" ");
                buffer.Clear();
            }
            else
            {
                buffer.Append(str[i]);
            }            
        }
        
        return sb.ToString().TrimEnd();  
    }
    
    public static string ReverseWordOrder1(string str)  
    {
        // O(n) time, O(n) space
        var words = str.Split();
        
        var sb = new StringBuilder();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
            sb.Append(" ");
        }
        
        return sb.ToString().TrimEnd();  
    }
}