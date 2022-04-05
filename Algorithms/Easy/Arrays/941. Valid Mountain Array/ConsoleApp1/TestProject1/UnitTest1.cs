using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 1 }, false)]
        [InlineData(new int[] { 3, 5, 5 }, false)]
        [InlineData(new int[] { 0, 3, 2, 1 }, true)]
        public void Test1(int[] input, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.ValidMountainArray(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
