using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }

    class Solution
    {
        private Dictionary<int, Employee> _empDictionary;

        public int GetImportance(IList<Employee> employees, int id)
        {
            _empDictionary = employees.ToDictionary(e => e.id, e => e);

            return GetEmployeeImportance(id);
        }

        private int GetEmployeeImportance(int id)
        {
            Employee employee = _empDictionary[id];
            int resultImportance = employee.importance;

            foreach (var subordinateId in employee.subordinates)
            {
                Employee subordinate = _empDictionary[subordinateId];
                resultImportance += GetEmployeeImportance(subordinateId);
            }

            return resultImportance;
        }
    }
}
