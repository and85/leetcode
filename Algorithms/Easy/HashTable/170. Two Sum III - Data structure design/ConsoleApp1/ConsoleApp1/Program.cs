using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new TwoSum();
            solution.Add(3);
            solution.Add(2);
            solution.Add(1);
            solution.Add(1);

            Console.WriteLine(solution.Find(2));
            

        }
    }
}
