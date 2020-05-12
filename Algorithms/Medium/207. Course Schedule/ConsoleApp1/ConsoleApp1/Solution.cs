using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/course-schedule/
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var uniqueCoures = new HashSet<int>();
            var courcesDictionary = new Dictionary<int, int>();
            foreach (int[] p in prerequisites)
            {
                int course = p[0];
                int prerequisite = p[1];
                if (!uniqueCoures.Contains(course))
                    uniqueCoures.Add(course);
                if (!uniqueCoures.Contains(prerequisite))
                    uniqueCoures.Add(prerequisite);

                // check number of taken cources
                if (uniqueCoures.Count > numCourses)
                    return false;

                // check self references
                if (!courcesDictionary.ContainsKey(course))
                    courcesDictionary.Add(course, prerequisite);

                if (courcesDictionary.ContainsKey(prerequisite))
                {
                    if (courcesDictionary[prerequisite] == course)
                        return false;
                }
            }
            

            return true;
        }
    }
}
