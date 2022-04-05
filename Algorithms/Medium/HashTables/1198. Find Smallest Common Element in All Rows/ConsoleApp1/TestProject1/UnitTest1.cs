using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var solution = new Solution();
            var input = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 2,4,5,8,10 },
                new int[] { 3,5,7,9,11 },
                new int[] { 1,3,5,7,9 }
            };

            // act
            var actual = solution.SmallestCommonElement(input);

            // assert
            Assert.Equal(5, actual);
        }

        [Fact]
        public void Test2()
        {
            // arrange
            var solution = new Solution();
            var input = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 2,3,4 },                
                new int[] { 2, 3, 5 }
            };

            // act
            var actual = solution.SmallestCommonElement(input);

            // assert
            Assert.Equal(2, actual);
        }
    }
}
