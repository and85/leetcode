using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase(5, 2)]
        [TestCase(9, 3)]
        [TestCase(15, 4)]
        [TestCase(93003, 8)]
        public void Test(int input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.ConsecutiveNumbersSum(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}