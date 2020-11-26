using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase(12, 30, 165)]
        [TestCase(3, 30, 75)]
        [TestCase(3, 15, 7.5)]
        [TestCase(4, 50, 155)]
        [TestCase(12, 0, 0)]
        [TestCase(1, 57, 76.5)]
        public void Test1(int hour, int minutes, double expected)
        {
            // arrange
            var solution = new Solution();

            // act
            double actual = solution.AngleClock(hour, minutes);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}