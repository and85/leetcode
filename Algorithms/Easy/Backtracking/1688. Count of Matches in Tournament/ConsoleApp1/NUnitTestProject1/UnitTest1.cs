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

        [TestCase(7, 6)]
        [TestCase(14, 13)]
        public void Test1(int n, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.NumberOfMatches(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}