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

        [TestCase("ABCABC", "ABC", "ABC")]
        [TestCase("ABABAB", "ABAB", "AB")]
        [TestCase("LEET", "CODE", "")]
        [TestCase("ABCDEF", "ABC", "")]
        [TestCase("AA", "A", "A")]
        public void Test1(string str1, string str2, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.GcdOfStrings(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}