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

        [TestCase(12, true)]
        [TestCase(91, true)]
        [TestCase(21, false)]
        public void Test1(int n, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.CheckPowersOfThree(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}