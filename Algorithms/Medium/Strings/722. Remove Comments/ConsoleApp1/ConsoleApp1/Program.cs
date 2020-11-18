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
            var solution = new Solution();

            string[] source = new string[] 
            {   
                "/*Test program */", 
                "int main()", 
                "{ ", 
                "  // variable declaration ", 
                "int a, b, c;", 
                "/* This is a test", 
                "   multiline  ", 
                "   comment for ", 
                "   testing */", 
                "a = b + c;", 
                "}" 
            };

            var result = solution.RemoveComments(source);
            foreach (string line in result)
                Console.WriteLine(line);


            Console.ReadLine();
        }
    }
}
