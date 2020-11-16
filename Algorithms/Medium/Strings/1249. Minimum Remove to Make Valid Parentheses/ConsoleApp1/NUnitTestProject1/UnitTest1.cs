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

        [TestCase("lee(t(c)o)de)", "lee(t(c)o)de")]
        [TestCase("a)b(c)d", "ab(c)d")]
        [TestCase("))((", "")]
        [TestCase("(a(b(c)d)", "a(b(c)d)")]
        public void Test1(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.MinRemoveToMakeValid(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}