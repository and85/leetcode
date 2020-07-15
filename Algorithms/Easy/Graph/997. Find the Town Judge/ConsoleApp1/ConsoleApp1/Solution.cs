using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        internal class Person
        {
            internal Person(int label)
            {
                Label = label;
            }

            internal int Label { get; set; }
            internal List<int> WhomITtust { get; set; } = new List<int>();

            internal List<int> WhoTrustsMe { get; set; } = new List<int>();
        }

        public int FindJudge(int N, int[][] trust)
        {
            if (N == 1)
                return 1;

            var allPersons = new Dictionary<int, Person>();

            foreach (int[] t in trust)
            {
                SetWhomITrust(allPersons, t);
                SetWhoTrustsMe(allPersons, t);
            }

            return FindJudge(allPersons, N);
        }

        private void SetWhomITrust(Dictionary<int, Person> allPersons, int[] t)
        {
            int personLabel = t[0];
            int whomITrust = t[1];

            Person person = GetPerson(allPersons, personLabel);
            person.WhomITtust.Add(whomITrust);
        }

        private Person GetPerson(Dictionary<int, Person> allPersons, int personLabel)
        {
            Person person;
            if (allPersons.ContainsKey(personLabel))
            {
                person = allPersons[personLabel];
            }
            else
            {
                person = new Person(personLabel);
                allPersons.Add(personLabel, person);
            }

            return person;
        }

        private void SetWhoTrustsMe(Dictionary<int, Person> allPersons, int[] t)
        {
            int personLabel = t[1];
            int whoTrustsMe = t[0];

            Person person = GetPerson(allPersons, personLabel);
            person.WhoTrustsMe.Add(whoTrustsMe);
        }

        private int FindJudge(Dictionary<int, Person> allPersons, int n)
        {
            foreach (var person in allPersons)
            {
                if (person.Value.WhomITtust.Count == 0 && person.Value.WhoTrustsMe.Count == n - 1)
                    return person.Value.Label;
            }

            return -1;
        }
    }
}
