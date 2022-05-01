using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { 1, 2, 2, 1 }, 4)]
        public void Test1(int[] input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.FindLHS(input);

            // assert
            Assert.Equal(actual, expected);
        }
    }
}
