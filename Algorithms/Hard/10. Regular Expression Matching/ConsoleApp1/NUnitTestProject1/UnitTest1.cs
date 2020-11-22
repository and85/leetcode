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

        [TestCase("aa", "a", false)]
        [TestCase("aa", "a.", true)]
        [TestCase("aa", "a*", true)]
        [TestCase("aab", "c*a*b", true)]
        [TestCase("ab", ".*", true)]
        [TestCase("mississippi", "mis*is*p*.", false)]
        [TestCase("aaab", "a*b", true)]
        [TestCase("aaab", "a*ab", true)]
        [TestCase("aaa", "a*a", true)]
        [TestCase("aaa", "ab*a*c*a", true)]
        public void Test(string s, string p, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.IsMatch(s, p);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}