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

        [TestCase("(()())(())", "()()()")]
        [TestCase("(()())(())(()(()))", "()()()()(())")]
        [TestCase("()()", "")]
        public void Test1(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.RemoveOuterParentheses(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}