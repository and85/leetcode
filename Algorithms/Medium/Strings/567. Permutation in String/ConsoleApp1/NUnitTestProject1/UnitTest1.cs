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