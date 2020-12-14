using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new int[] { 28, 54, 7, -70, 22, 65, -6 }, 100, 1)]
        [TestCase(new int[] { 1, -1, 0}, 0, 3)]
        [TestCase(new int[] {  }, 1, 0)]
        //[TestCase(new int[] { 1, 2, 55, 3, 4 }, 300, 2)]
        [TestCase(new int[] { 1, 1, 1}, 2, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 3, 2)]
        public void Test1(int[] nums, int k, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.SubarraySum(nums, k);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}