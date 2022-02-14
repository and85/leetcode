using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void Test1(int[] nums, int target, List<int> expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.TargetIndices(nums, target);

        // assert
        Assert.Equal(expected, actual);
    }

    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new[] { 1, 2, 5, 2, 3 }, 2, new List<int>() { 1, 2 } };
            yield return new object[] { new[] { 1, 2, 5, 2, 3 }, 3, new List<int>() { 3 } };
            yield return new object[] { new[] { 1, 2, 5, 2, 3 }, 5, new List<int>() { 4 } };
            yield return new object[] { new[] { 1, 2, 5, 2, 3 }, 55, new List<int>() { } };
            yield return new object[] { new[] { 1, 2, 5, 2, 3 }, 0, new List<int>() { } };
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}