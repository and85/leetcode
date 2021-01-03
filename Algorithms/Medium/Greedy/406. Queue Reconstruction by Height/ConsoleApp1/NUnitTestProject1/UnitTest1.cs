using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
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
            var input = new int[][]
            {
                new int[] { 7, 0 },
                new int[] { 4, 4 },
                new int[] { 7, 1 },
                new int[] { 5, 0 },
                new int[] { 6, 1 },
                new int[] { 5, 2 }
            };

            var expected = new int[][]
            {
                new int[] { 5, 0 },
                new int[] { 7, 0 },
                new int[] { 5, 2 },
                new int[] { 6, 1 },
                new int[] { 4, 4 },
                new int[] { 7, 1 }
            };

            // act
            var actual = solution.ReconstructQueue(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var solution = new Solution();
            var input = new int[][]
            {
                new int[] { 6, 0 },
                new int[] { 5, 0 },
                new int[] { 4, 0 },
                new int[] { 3, 2 },
                new int[] { 2, 2 },
                new int[] { 1, 4 }
            };

            var expected = new int[][]
            {
                new int[] { 4, 0 },
                new int[] { 5, 0 },
                new int[] { 2, 2 },
                new int[] { 3, 2 },
                new int[] { 1, 4 },
                new int[] { 6, 0 }
            };

            // act
            var actual = solution.ReconstructQueue(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}