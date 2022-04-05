using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abccccdd", 7)]
        [InlineData("a", 1)]
        [InlineData("bb", 2)]
        [InlineData("AAA", 3)]
        public void Test1(string str, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.LongestPalindrome(str);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
