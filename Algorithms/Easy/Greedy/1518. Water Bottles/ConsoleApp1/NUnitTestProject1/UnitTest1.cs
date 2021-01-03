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

        [TestCase(9, 3, 13)]
        [TestCase(15, 4, 19)]
        public void Test1(int numBottles, int numExchange, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.NumWaterBottles(numBottles, numExchange);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}