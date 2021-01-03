using ConsoleApp1;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;

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
        //[TestCaseSource(typeof(MyFactoryClass), "TestCases")]
        public void TestTwoCitySchedCost1()
        {
            // arrange
            int expected = 110;
            var costs = new int[][]
            {
                new int[] { 10,20},
                new int[] { 30, 200},
                new int[] { 400, 50},
                new int[] { 30, 20}
            };

            // act
            var solution = new Solution();
            int actual = solution.TwoCitySchedCost(costs);


            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTwoCitySchedCost2()
        {
            // arrange
            int expected = 1859;
            var costs = new int[][]
            {
                new int[] { 259, 770 },
                new int[] { 448, 54 },
                new int[] { 926, 667 },
                new int[] { 184, 139 },
                new int[] { 840, 118 },
                new int[] { 577, 469 }
            };

            // act
            var solution = new Solution();
            int actual = solution.TwoCitySchedCost(costs);


            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTwoCitySchedCost3()
        {
            // arrange
            int expected = 3086;
            var costs = new int[][]
            {
                new int[] { 515,563 },
                new int[] { 451,713 },
                new int[] { 537,709 },
                new int[] { 343,819 },
                new int[] { 855,779 },
                new int[] { 457, 60 },
                new int[] { 650, 359 },
                new int[] { 631, 42 },
            };

            // act
            var solution = new Solution();
            int actual = solution.TwoCitySchedCost(costs);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}