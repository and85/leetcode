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

        
        [TestCase(0, 1)]
        [TestCase(1, 10)]
        [TestCase(2, 91)]
        [TestCase(3, 91)]
        [TestCase(4, 5040)]
        public void Test1(int input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.CountNumbersWithUniqueDigits(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}