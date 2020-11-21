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

        [TestCase("32+21*2", 76)]
        [TestCase("32+21+2", 55)]
        [TestCase("32+21-2", 51)]
        [TestCase("32*2+2", 66)]
        [TestCase("3+2*2", 7)]
        [TestCase(" 3 / 2 ", 1)]
        [TestCase(" 3+5 / 2 ", 5)]
        public void Test(string input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.Calculate(input);

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}