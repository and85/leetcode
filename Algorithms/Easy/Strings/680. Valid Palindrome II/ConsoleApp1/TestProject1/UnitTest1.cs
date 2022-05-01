using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aba", true)]
        [InlineData("abca", true)]
        [InlineData("abc", false)]
        [InlineData("a", true)]
        [InlineData("aaa", true)]
        [InlineData("aaab", true)]
        [InlineData("aaabc", false)]
        [InlineData("abecbea", false)]
        [InlineData("abecba", true)]
        [InlineData("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga", true)]
        public void Test1(string input, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.ValidPalindrome(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
