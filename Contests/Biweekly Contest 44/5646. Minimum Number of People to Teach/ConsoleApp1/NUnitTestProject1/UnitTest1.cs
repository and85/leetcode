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

            // act
            var languages = new int[][]
            {
                new int[] { 1},
                new int[] { 2 },
                new int[] { 1, 2}
            };

            var friendships = new int[][]
            {
                new int[] { 1, 2},
                new int[] { 1, 3 },
                new int[] { 2, 3}
            };

            int actual = solution.MinimumTeachings(2, languages, friendships);

            // assert
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var solution = new Solution();

            // act
            var languages = new int[][]
            {
                new int[] { 2},
                new int[] { 1, 3 },
                new int[] { 1, 2},
                new int[] { 3}
            };

            var friendships = new int[][]
            {
                new int[] { 1, 4},
                new int[] { 1, 2 },
                new int[] { 3, 4},
                new int[] { 2, 3}
            };

            int actual = solution.MinimumTeachings(3, languages, friendships);

            // assert
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Test3()
        {
            // arrange
            var solution = new Solution();

            // act
            var languages = new int[][]
            {
                new int[] { 3, 11, 5, 10, 1, 4, 9, 7, 2, 8, 6},
                new int[] { 5,10,6,4,8,7 },
                new int[] { 6,11,7,9},
                new int[] { 11, 10, 4 },
                new int[] { 6, 2, 8, 4, 3 },
                new int[] { 7,5,11,1,3,4 },
                new int[] { 3,4,11,10,6,2,1,7,5,8,9 },
                new int[] { 8,6,10,2,3,1,11,5 },
                new int[] { 5,11,6,4,2 },
            };



            var friendships = new int[][]
            {
                new int[] { 7, 9 },
                new int[] { 3, 7 },
                new int[] { 3, 4 },
                new int[] { 2, 9 },
                new int[] { 1, 8 },
                new int[] { 5, 9 },
                new int[] { 8, 9 },
                new int[] { 6, 9 },
                new int[] {3,5}, 
                new int[] {4,5}, 
                new int[] {4,9}, 
                new int[] {3,6}, 
                new int[] {1,7}, 
                new int[] {1,3},
                new int[] {2,8}, 
                new int[] {2,6}, 
                new int[] {5,7}, 
                new int[] {4,6}, 
                new int[] {5,8}, 
                new int[] {5,6},
                new int[] {2,7}, 
                new int[] {4,8}, 
                new int[] {3,8}, 
                new int[] {6,8}, 
                new int[] {2,5}, 
                new int[] {1,4}, 
                new int[] {1,9}, 
                new int[] {1,6}, 
                new int[] {6,7 }
            };

            int actual = solution.MinimumTeachings(11, languages, friendships);

            // assert
            Assert.AreEqual(0, actual);
        }
    }
}