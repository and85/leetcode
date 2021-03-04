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
            var solution = new Solution();

            // act
            int actual = solution.FindMinArrowShots(new int[][]
            {
                new int[] { 10, 16},
                new int[] { 2, 8},
                new int[] { 1, 6},
                new int[] { 7, 12}
            });

            // assert
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.FindMinArrowShots(new int[][]
            {
                new int[] { 1, 2},
                new int[] { 3, 4},
                new int[] { 5, 6},
                new int[] { 7, 8}
            });

            // assert
            Assert.AreEqual(4, actual);
        }

        [Test]
        public void Test3()
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.FindMinArrowShots(new int[][]
            {
                new int[] { 3, 9},
                new int[] { 7, 12},
                new int[] { 3, 8},
                new int[] { 6, 8},
                new int[] { 9, 10},
                new int[] { 2, 9},
                new int[] { 0, 9},
                new int[] { 3, 9},
                new int[] { 0, 6},
                new int[] { 2, 8}
            });

            // assert
            Assert.AreEqual(2, actual);
        }
    }
}