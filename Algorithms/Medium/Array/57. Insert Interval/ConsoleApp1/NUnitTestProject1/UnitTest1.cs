using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            var intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 }
            };

            var newInterval = new int[] { 2, 5 };

            var solution = new Solution();

            // act
            solution.Insert(intervals, newInterval);

            // assert
        }

        [Test]
        public void Test2()
        {
            // arrange
            var intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 }
            };

            var newInterval = new int[] { 2, 5 };

            var solution = new Solution();

            // act
            solution.Insert(intervals, newInterval);

            // assert
        }
    }
}