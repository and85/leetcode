using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            var solution = new Solution();
            int expected = 2;

            // act
            int actual = solution.MinMeetingRooms(new int[][] 
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 }
            });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var solution = new Solution();
            int expected = 1;

            // act
            int actual = solution.MinMeetingRooms(new int[][]
            {
                new int[] { 7, 10 },
                new int[] { 2, 4 }
            });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            // arrange
            var solution = new Solution();
            int expected = 1;

            // act
            int actual = solution.MinMeetingRooms(new int[][]
            {
                new int[] { 13, 15 },
                new int[] { 1, 13 }
            });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            // arrange
            var solution = new Solution();
            int expected = 2;

            // act
            int actual = solution.MinMeetingRooms(new int[][]
            {
                new int[] { 9, 10 },
                new int[] { 4, 9 },
                new int[] { 4, 17 },
            });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            // arrange
            var solution = new Solution();
            int expected = 2;

            // act
            int actual = solution.MinMeetingRooms(new int[][]
            {
                new int[] { 5, 8 },
                new int[] { 6, 8 }
            });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test6()
        {
            // arrange
            var solution = new Solution();
            int expected = 2;

            // act
            int actual = solution.MinMeetingRooms(new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 8, 9 },
                new int[] { 8, 9 }
            });

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}