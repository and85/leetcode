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

        [TestCase("ab", "eidbaooob", true)]
        [TestCase("ab", "eidboaoo", false)]
        [TestCase("abc", "eidabcoaoo", true)]
        [TestCase("abc", "eidabocaoo", false)]
        [TestCase("a", "a", true)]
        [TestCase("ab", "ba", true)]
        [TestCase("abc", "ba", false)]
        [TestCase("abb", "acab", false)]
        [TestCase("abb", "acbab", true)]
        [TestCase("abb", "false", false)]
        [TestCase("abbb", "abbcb", false)]
        [TestCase("abbb", "cabbb", true)]
        [TestCase("bbab", "cabbb", true)]
        [TestCase("adc", "dcda", true)]
        public void Test1(string s1, string s2, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.CheckInclusion(s1, s2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}