using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private Queue<int> _killedProcesses = new Queue<int>();
        private Dictionary<int, List<int>> _processTree = new Dictionary<int, List<int>>();

        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var pids = pid.ToArray<int>();
            var ppids = ppid.ToArray<int>();

            for (int i = 0; i < ppids.Length; i++)
            {
                if (!_processTree.ContainsKey(ppids[i]))
                {
                    _processTree.Add(ppids[i], new List<int>() { pid[i]});
                }
                else
                {
                    _processTree[ppids[i]].Add(pid[i]);
                }
            }

            return Kill(kill);
        }

        //private IList<int> Kill(int kill)
        //{
        //    _killedProcesses.Enqueue(kill);

        //    if (_processTree.ContainsKey(kill))
        //    {
        //        List<int> childs = _processTree[kill];
        //        foreach (int child in childs)
        //        {
        //            //_killedProcesses.Enqueue(child);
        //            Kill(child);
        //        }
        //    }

        //    return _killedProcesses
        //        //.Distinct<int>()
        //        .ToList();
        //}

        private IList<int> Kill(int kill)
        {
            List<int> res = new List<int>();
            _killedProcesses.Enqueue(kill);
            res.Add(kill);

            while (_killedProcesses.Count != 0)
            {
                int process = _killedProcesses.Dequeue();
                if (_processTree.ContainsKey(process))
                {
                    List<int> childs = _processTree[process];
                    foreach (int child in childs)
                    {
                        _killedProcesses.Enqueue(child);
                        res.Add(child);
                    }
                }
            }

            return res;
        }
    }
}
