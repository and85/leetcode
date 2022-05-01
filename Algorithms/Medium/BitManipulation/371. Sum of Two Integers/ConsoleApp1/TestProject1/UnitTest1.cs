using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void Test1(int a, int b, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.GetSum(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
