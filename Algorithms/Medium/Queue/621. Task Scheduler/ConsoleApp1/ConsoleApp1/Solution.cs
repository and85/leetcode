using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/task-scheduler/
    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int leastInterval = 0;
            char idle = '0';

            Dictionary<char, int> taskEntrance = tasks.GroupBy(t => t)
                .ToDictionary(g => g.Key, g => g.Count());

            var lastProcessedTasks = new Queue<char>();
            var leftTasks = new List<char>(tasks);

            while (leftTasks.Count != 0)
            {
                bool taskDone = false;
                foreach (var task in taskEntrance.ToList())
                {
                    if (CanExecute(task.Key, taskEntrance, lastProcessedTasks))
                    {
                        EnqueueTask(lastProcessedTasks, task.Key, n);
                        taskDone = true;
                        leastInterval += 1;
                        leftTasks.Remove(task.Key);
                        break;
                    }
                }

                if (!taskDone)
                {
                    leastInterval += 1;
                    EnqueueTask(lastProcessedTasks, idle, n);
                }
            }

            return leastInterval;
        }

        private static void EnqueueTask(Queue<char> queue, char task, int capacity)
        {
            if (queue.Count == capacity && queue.Count > 0)
            {
                queue.Dequeue();
            }

            if (capacity > 0)
                queue.Enqueue(task);
        }

        private bool CanExecute(char task, Dictionary<char, int> taskEntrance, Queue<char> queue)
        {
            if (taskEntrance.ContainsKey(task) && taskEntrance[task] > 0 && !queue.Contains(task))
            {
                taskEntrance[task]--;
                return true;
            }
            return false;

        }
    }
}
