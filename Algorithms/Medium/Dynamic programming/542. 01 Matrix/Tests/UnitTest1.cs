using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void Test1(int[][] mat, int[][] expected)
    {
        // arrange
        var s = new Solution();

        // act
        var actual = s.UpdateMatrix(mat);

        // assert
        Assert.Equal(expected, actual);
    }

    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] 
            { 
                // mat
                new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } },  
                // expected
                new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } }
            };

            yield return new object[] 
            { 
                // mat
                new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } },  
                // expected
                new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 2, 1 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}