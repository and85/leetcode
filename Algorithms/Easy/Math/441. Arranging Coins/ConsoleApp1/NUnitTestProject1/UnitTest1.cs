using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase(1, 1)]
        [TestCase(5, 2)]
        [TestCase(8, 3)]
        [TestCase(28, 7)]
        [TestCase(2147483647, 65535)]
        public void Test(int n, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.ArrangeCoins(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}