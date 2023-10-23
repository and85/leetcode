using System.Text;

public class Solution
{
    public static string ReverseWords(string str)  
    {
        // [InlineData("Welcome to Csharp corner", "emocleW ot prahsC renroc")]
                
        var sb = new StringBuilder();
        var buff = new StringBuilder();
        
        for (int i = 0; i <= str.Length; i++)
        {
            if (i == str.Length || str[i] == ' ')
            {
                var a = buff.ToString().ToCharArray().Reverse().ToArray();
                sb.Append(new string(a));
                sb.Append(' ');
                buff.Clear();
            }
            else
            {
                buff.Append(str[i]);
            }
        }

        
        return sb.ToString().TrimEnd();  
    }   
}