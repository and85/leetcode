using ConsoleApp1;
using NUnit.Framework;
using System.Collections.Generic;

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
            var actual = solution.PartitionLabels("ababcbacadefegdehijhklij");

            // assert
            CollectionAssert.AreEqual(new List<int>() { 9, 7, 8 }, actual);

        }
    }
}