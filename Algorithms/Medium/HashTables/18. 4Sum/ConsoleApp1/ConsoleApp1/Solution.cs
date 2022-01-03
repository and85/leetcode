using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        class NumSet : IEquatable<NumSet>
        {
            public List<int> List { get; set; }
            public HashSet<int> HashSet { get; set; }

            public NumSet(List<int> quadruplet)
            {
                List = quadruplet.OrderBy(q => q).ToList();
                HashSet = new HashSet<int>(quadruplet);
            }

            public bool Equals(NumSet other)
            {

                return Enumerable.SequenceEqual(List.OrderBy(n => n), other.List.OrderBy(n => n));



                //return other.List.All(o => HashSet.Contains(o)) && List.All(o => other.HashSet.Contains(o));

                //for (int i = 0; i < other.List.Count; i++)
                //{
                //    if (List[i] != other.List[i]) return false;
                //}
                
            }

            public override int GetHashCode()
            {
                int hashCode = List.First().GetHashCode(); 
                for (int i = 1; i < List.Count; i++)
                {
                    hashCode ^= List[i].GetHashCode();
                }

                return hashCode;
            }
        }
        

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            //Array.Sort(nums);

            var hashSet = new HashSet<NumSet>();
            var result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                var threeSum = ThreeSum(nums, target - nums[i], i);
                if (threeSum.Count > 0)
                {
                    foreach (var threeruplet in threeSum)
                    {
                        threeruplet.Add(nums[i]);
                        var set = new NumSet(threeruplet);
                        if (!hashSet.Contains(set))
                        {
                            hashSet.Add(set);
                            result.Add(set.List);
                        }
                    }
                }
            }

            return result;
        }

        private List<List<int>> ThreeSum(int[] nums, int target, int ignoreIndex)
        {
            var result = new List<List<int>>();
            var hashSet = new HashSet<NumSet>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == ignoreIndex) continue;

                var twoSum = TwoSum(nums, target - nums[i], i, ignoreIndex);
                if (twoSum.Count > 0)
                {
                    foreach (var duplet in twoSum)
                    {
                        duplet.Add(nums[i]);
                        var set = new NumSet(duplet);
                        if (!hashSet.Contains(set))
                        {
                            hashSet.Add(set);
                            result.Add(set.List);
                        }
                    }
                }
            }

            return result;
        }

        private List<List<int>> TwoSum(int[] nums, int target, int ignoreIndex1, int ignoreIndex2)
        {
            var result = new List<List<int>>();
            var hashSet = new HashSet<NumSet>();
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == ignoreIndex1 || i == ignoreIndex2) continue;

                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]].Add(i);
                else
                    dict.Add(nums[i], new List<int>() { i });

            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == ignoreIndex1 || i == ignoreIndex2) continue;

                int key = target - nums[i];
                if (dict.ContainsKey(key))
                {
                    foreach (int index in dict[key].Where(v => v != i))
                    {
                        var set = new NumSet(new List<int>() { nums[i], nums[index] });
                        if (!hashSet.Contains(set))
                        {
                            hashSet.Add(set);
                            result.Add(set.List);
                        }
                    }
                }
            }

            return result;
        }
    }
}
