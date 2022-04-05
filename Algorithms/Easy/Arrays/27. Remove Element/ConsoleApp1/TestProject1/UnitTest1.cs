using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void Test1(int[] input, int val, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.RemoveElement(input, val);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
