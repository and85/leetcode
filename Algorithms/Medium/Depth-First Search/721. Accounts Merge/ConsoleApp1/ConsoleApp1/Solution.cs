using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        // fails test cases because of correctness
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var groups = new Dictionary<string, Dictionary<int, HashSet<string>>>();
            int accountNum = 0;
            foreach (var account in accounts)
            {
                string name = account.First();
                var emails = account.Skip(1).ToHashSet();
                if (!groups.ContainsKey(name))
                {
                    var newAccount = new Dictionary<int, HashSet<string>>();
                    newAccount.Add(++accountNum, new HashSet<string>(emails));
                    groups.Add(name, newAccount);
                }
                else
                {
                    var mergedAccount = groups[name];
                    bool accountFound = false;
                    foreach (var a in mergedAccount)
                    {
                        if (AccountExists(emails, a))
                        {
                            mergedAccount[a.Key].UnionWith(emails);
                            accountFound = true;
                            break;
                        }
                    }

                    if (!accountFound)
                        mergedAccount.Add(++accountNum, emails);
                }
            }

            var result = new List<IList<string>>();
            foreach (var group in groups)
            {
                foreach (var g in group.Value)
                {
                    var a = new List<string>();
                    a.Add(group.Key);
                    a.AddRange(g.Value.OrderBy(e => e, StringComparer.Ordinal));
                    
                    result.Add(a);
                }
            }

            return result;
        }

        private bool AccountExists(HashSet<string> emails, KeyValuePair<int, HashSet<string>> a)
        {
            return a.Value.Any(e => emails.Contains(e));
        }
    }
}
