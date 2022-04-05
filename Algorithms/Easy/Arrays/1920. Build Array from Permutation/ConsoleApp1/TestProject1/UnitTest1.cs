using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] { 0, 1, 2, 4, 5, 3 })]
        [InlineData(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
        public void Test1(int[] input, int[] expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.BuildArray(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
