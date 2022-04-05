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

        [TestCase("2326", 4)]
        [TestCase("12", 2)]
        [TestCase("226", 3)]
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        public void Test1(string input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.NumDecodings(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}