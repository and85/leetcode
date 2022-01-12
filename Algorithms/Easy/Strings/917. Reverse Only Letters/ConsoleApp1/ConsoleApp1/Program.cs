using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public string ReverseOnlyLetters(string s)
        {
            var arr = s.ToCharArray();

            int i = 0, j = arr.Length - 1;
            
            while (j > i)
            {
                if (char.IsLetter(arr[i]) && char.IsLetter(arr[j]))
                {
                    char t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    i++;
                    j--;
                }
                else if (char.IsLetter(arr[i]))
                {
                    j--;
                }
                else
                    i++;
            }

            return new string(arr);
        }
    }
}
