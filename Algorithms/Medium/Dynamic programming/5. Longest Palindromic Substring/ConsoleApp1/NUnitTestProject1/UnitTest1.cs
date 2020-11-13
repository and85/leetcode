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

        [TestCase("babad", "bab")]
        [TestCase("cbbd", "bb")]
        [TestCase("a", "a")]
        [TestCase("ac", "a")]
        public void Test1(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.LongestPalindrome(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}