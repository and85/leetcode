using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("00110", 1)]
        [InlineData("010110", 2)]
        [InlineData("00011000", 2)]
        [InlineData("0101100011", 3)]
        [InlineData("10011111110010111011", 5)]
        public void Test1(string s, int exected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.MinFlipsMonoIncr(s);

            // assert
            Assert.Equal(exected, actual);
        }
    }
}
