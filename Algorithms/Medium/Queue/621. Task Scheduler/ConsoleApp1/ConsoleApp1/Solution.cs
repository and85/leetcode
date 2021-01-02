using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/task-scheduler/
    public class Solution
    {
        private const char IdleTask = '0';
        private int _cooldown;

        public int LeastInterval(char[] tasks, int n)
        {
            if (n == 0)
                return tasks.Length;

            _cooldown = n;

            int leastInterval = 0;
            var executedTasks = new Queue<char>();

            var allTasks = tasks.GroupBy(t => t).ToDictionary(t => t.Key, t => t.Count());

            while (allTasks.Count > 0)
            {
                var task = GetMostCommonTask(allTasks, executedTasks.ToList());

                if (!executedTasks.Contains(task) && !task.Equals(IdleTask))
                {
                    allTasks[task]--;
                    if (allTasks[task] == 0)
                        allTasks.Remove(task);

                    AddExecutedTask(executedTasks, task);
                    leastInterval++;
                }

                if (task.Equals(IdleTask))
                {
                    AddExecutedTask(executedTasks, IdleTask);
                    leastInterval++;
                }
            }

            return leastInterval;
        }

        private char GetMostCommonTask(Dictionary<char, int> allTasks, List<char> executedTasks)
        {
            int max = 0;
            char maxTask = IdleTask;
            foreach (var t in allTasks)
            {
                if (t.Value > max && !executedTasks.Contains(t.Key))
                {
                    max = t.Value;
                    maxTask = t.Key;
                }
            }
            return maxTask;
        }

        private void AddExecutedTask(Queue<char> executedTasks, char task)
        {
            if (executedTasks.Count == _cooldown)
                executedTasks.Dequeue();

            executedTasks.Enqueue(task);
        }
    }
}
