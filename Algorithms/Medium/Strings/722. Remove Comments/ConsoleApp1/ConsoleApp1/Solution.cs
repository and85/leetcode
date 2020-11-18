using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<string> RemoveComments(string[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                // we could speed up index search if we used binary search instead
                int singleLineInd = source[i].IndexOf("//");
                
                // we could have more than one multiline comment in a string
                int multiLineOpenInd = source[i].IndexOf("/*");
                int multiLineCloseInd = source[i].IndexOf("*/");

                daea */ // /* fdsdfsf // */ dsdsd /*dsd*/

                if (!IsMultiLineOpen() && IsSingleLineComment())
                {

                }


                //Console.WriteLine($"{source[i]} | index1 {singlelineInd} index2 {multilineOpenInd} index3 {multilineCloseInd}");
            }

            return new List<string>() { "a", "b" };
        }

        private bool IsSingleLineComment()
        {
            throw new NotImplementedException();
        }

        private bool IsMultiLineOpen()
        {
            throw new NotImplementedException();
        }
    }
}
