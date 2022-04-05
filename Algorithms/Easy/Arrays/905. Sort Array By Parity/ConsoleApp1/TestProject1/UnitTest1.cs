using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4 })]
        public void Test1(int[] nums)
        {
            // arrange
            var solution = new Solution();

            // act
            solution.SortArrayByParity(nums);

            // assert
        }
    }
}
