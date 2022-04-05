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

            // act
            string actual = solution.StringShift("abc", new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 } });

            // assert
            Assert.Equal("cab", actual);
        }

        [Fact]
        public void Test2()
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.StringShift("abcdefg", new int[][] { new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 0, 2 }, new int[] { 1, 3 } });

            // assert
            Assert.Equal("efgabcd", actual);
        }

        [Fact]
        public void Test3()
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.StringShift("abc", new int[][] { new int[] { 0, 4 } });

            // assert
            Assert.Equal("bca", actual);
        }

        [Fact]
        public void Test4()
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.StringShift("a", new int[][] { new int[] { 0, 4 } });

            // assert
            Assert.Equal("a", actual);
        }
    }
}
