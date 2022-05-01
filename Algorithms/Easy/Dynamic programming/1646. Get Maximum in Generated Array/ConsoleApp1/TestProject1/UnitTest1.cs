using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(7, 3)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(15, 5)]
        public void Test1(int n, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.GetMaximumGenerated(n);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
