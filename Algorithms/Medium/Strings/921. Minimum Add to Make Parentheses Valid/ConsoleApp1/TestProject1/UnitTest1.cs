using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("())", 1)]
        [InlineData("(((", 3)]
        public void Test1(string input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.MinAddToMakeValid(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
