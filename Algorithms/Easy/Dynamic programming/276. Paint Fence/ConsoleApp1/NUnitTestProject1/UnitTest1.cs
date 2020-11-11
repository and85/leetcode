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

        [TestCase(3, 2, 6)]
        public void Test1(int n, int k, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.NumWays(n, k);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}