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

        [TestCase(5, new int[] { 3, 4, 1, 1, 0, 0 }, 1)]
        [TestCase(3 , new int[] { 0, 0, 0, 0 }, -1)]
        [TestCase(7, new int[] { 1, 2, 1, 0, 2, 1, 0, 1 }, 3)]
        [TestCase(8, new int[] { 4, 0, 0, 0, 0, 0, 0, 0, 4 }, 2)]
        [TestCase(8, new int[] { 4, 0, 0, 0, 4, 0, 0, 0, 4 }, 1)]
        public void TestMinTaps(int n, int[] ranges, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.MinTaps(n, ranges);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}