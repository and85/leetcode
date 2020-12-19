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
            var accounts = new List<IList<string>> 
            { 
                new List<string>() { "John", "johnsmith@mail.com", "john00@mail.com" },
                new List<string>() { "John", "johnnybravo@mail.com" },
                new List<string>() { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new List<string>() { "Mary", "mary@mail.com" }
            };

            var solution = new Solution();
            solution.AccountsMerge(accounts);

            Console.ReadLine();
        }
    }
}
