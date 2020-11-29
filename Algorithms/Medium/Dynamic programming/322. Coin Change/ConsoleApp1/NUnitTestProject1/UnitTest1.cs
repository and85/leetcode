using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 5 }, 11, 3)]
        [TestCase(new int[] { 2 }, 3, -1)]
        [TestCase(new int[] { 1 }, 0, 0)]
        [TestCase(new int[] { 1 }, 1, 1)]
        [TestCase(new int[] { 1 }, 2, 2)]
        [TestCase(new int[] { 2 }, 1, -1)]
        [TestCase(new int[] { 2 }, 4, 2)]
        [TestCase(new int[] { 186, 419, 83, 408 }, 6249, 20)]
        public void Test1(int[] coins, int target, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.CoinChange(coins, target);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}