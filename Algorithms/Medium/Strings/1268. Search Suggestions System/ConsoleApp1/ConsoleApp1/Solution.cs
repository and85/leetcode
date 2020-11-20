using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            var result = new List<IList<string>>();
            var matchedProducts = new List<string>(products);

            var sb = new StringBuilder();
            foreach (char letter in searchWord)
            {
                sb.Append(letter);
                matchedProducts = matchedProducts.Where(p => p.StartsWith(sb.ToString())).ToList();
                result.Add(matchedProducts.Take(3).ToList());
            }

            return result;
        }
    }
}
