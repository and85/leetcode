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
            var solution = new Solution();
            var groups = new int[][] 
            {
                new int[]{ 1, -1, -1},
                new int[] { 3, -2, 0}
            };
            var nums = new int[] { 1, -1, 0, 1, -1, -1, 3, -2, 0 };

            bool actual = solution.CanChoose(groups, nums);

            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Test2()
        {
            var solution = new Solution();
            var groups = new int[][]
            {
                new int[]{ 10, -2},
                new int[] { 1, 2, 3, 4}
            };
            var nums = new int[] { 1, 2, 3, 4, 10, -2 };

            bool actual = solution.CanChoose(groups, nums);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Test3()
        {
            var solution = new Solution();
            var groups = new int[][]
            {
                new int[]{ 1, 2, 3},
                new int[] { 3, 4 }
            };
            var nums = new int[] { 7, 7, 1, 2, 3, 4, 7, 7 };

            bool actual = solution.CanChoose(groups, nums);

            Assert.AreEqual(false, actual);
        }
    }
}