using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            int[][] result = new int[people.Length][];
            var selectedIds = new List<int>();

            int person;
            var selectedPeople = new HashSet<int>();
            var remainingPeople = new HashSet<int>();
            for (int i = 0; i < people.Length; i++)
                remainingPeople.Add(i);

            // todo: do we need this loop? can'w we just iterate throuh remaining people and populate 
            // result list?
            //for (int position = 0; position < people.Length; position++)
            while (remainingPeople.Count > 0)
            {
                person = GetShortestCandidate(people, selectedPeople, remainingPeople);
                selectedPeople.Add(person);
                remainingPeople.Remove(person);
                //result[position] = people[person];
                selectedIds.Add(person);
            }

            int counter = 0;
            foreach (var id in selectedIds)
            {
                result[counter++] = people[id];
            }
            
            return result;
        }

        private int GetShortestCandidate(
            int[][] people, 
            HashSet<int> selectedPeople, 
            HashSet<int> remainingPeople)
        {
            int minIndex = int.MaxValue, minHeight = int.MaxValue, height;
            foreach (int i in remainingPeople)
            {
                if (IsFeasiblePerson(people, selectedPeople, i))
                {
                    height = people[i][0];
                    if (minHeight > height)
                    {
                        minHeight = height;
                        minIndex = i;
                    }
                }

            }

            return minIndex;
        }

        private bool IsFeasiblePerson(int[][] people, HashSet<int> selectedPeople, int person)
        {
            int personHeight = people[person][0];
            int expectedPeopleInFront = people[person][1];

            int peopleInFront = selectedPeople.Count(p => people[p][0] >= personHeight);

            return expectedPeopleInFront == peopleInFront;
        }
    }
}
