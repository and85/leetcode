using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase(12, 3)]
        [TestCase(13, 2)]
        public void Test1(int n, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.NumSquares(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}