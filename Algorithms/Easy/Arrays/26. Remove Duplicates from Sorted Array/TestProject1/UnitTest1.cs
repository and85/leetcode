using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void Test1(int[] input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.RemoveDuplicates(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
