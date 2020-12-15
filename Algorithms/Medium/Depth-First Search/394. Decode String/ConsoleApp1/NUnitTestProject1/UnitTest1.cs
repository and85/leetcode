using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase("3[a]2[bc]", "aaabcbc")]
        [TestCase("3[a2[c]]", "accaccacc")]
        [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
        [TestCase("abc3[cd]xyz", "abccdcdcdxyz")]
        public void Test1(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.DecodeString(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}