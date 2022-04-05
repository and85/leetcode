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
            var grid = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 } };

            // act
            var actual = solution.ShortestPathBinaryMatrix(grid);

            // assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Test2()
        {
            // arrange
            var solution = new Solution();
            var grid = new int[][] { new int[] { 0, 0, 0 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0} };

            // act
            var actual = solution.ShortestPathBinaryMatrix(grid);

            // assert
            Assert.Equal(4, actual);
        }

        [Fact]
        public void Test3()
        {
            // arrange
            var solution = new Solution();
            var grid = new int[][] { new int[] { 1, 0, 0 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 } };

            // act
            var actual = solution.ShortestPathBinaryMatrix(grid);

            // assert
            Assert.Equal(-1, actual);
        }
    }
}
