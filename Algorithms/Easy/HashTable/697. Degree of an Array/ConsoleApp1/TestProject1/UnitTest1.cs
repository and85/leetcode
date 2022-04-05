using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3, 1 }, 2)]
        [InlineData(new int[] { 1, 2, 2, 3, 1, 4, 2 }, 6)]
        public void Test1(int[] input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.FindShortestSubArray(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
