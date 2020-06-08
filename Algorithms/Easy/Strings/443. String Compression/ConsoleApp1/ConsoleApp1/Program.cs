using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            var s = new Solution();
            s.Compress(input);

            //char[] input2= new char[] { 'a'};
            //var s2 = new Solution();
            //s2.Compress(input2);

            //char[] input3 = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            //char[] input3 = new char[] { 'a', 'b', 'b', 'b' };

            //var s3 = new Solution();
            //s3.Compress(input3);

            Console.ReadLine();

        }
    }
}
