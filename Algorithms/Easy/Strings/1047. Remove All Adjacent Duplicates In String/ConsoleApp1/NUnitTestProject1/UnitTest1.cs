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

        [TestCase("abbaca", "ca")]
        [TestCase("abba", "")]
        [TestCase("abb", "a")]
        [TestCase("a", "a")]
        [TestCase("aaaaaaaaa", "a")]
        [TestCase("baaaaaaaaa", "ba")]
        public void Test1(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.RemoveDuplicates(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}