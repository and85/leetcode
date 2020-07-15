using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindJudgeTest1()
        {

            // arrange
            int n = 2;
            var trust = new int[][] { new int[] { 1, 2 } };
            int expected = 2;

            // act
            int actual = new Solution().FindJudge(n, trust);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudgeTest2()
        {

            // arrange
            int n = 3;
            var trust = new int[][] { new int[] { 1, 3 }, new int[] { 2, 3} };
            int expected = 3;

            // act
            int actual = new Solution().FindJudge(n, trust);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudgeTest3()
        {

            // arrange
            int n = 3;
            var trust = new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } };
            int expected = -1;

            // act
            int actual = new Solution().FindJudge(n, trust);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudgeTest4()
        {

            // arrange
            int n = 3;
            var trust = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 } };
            int expected = -1;

            // act
            int actual = new Solution().FindJudge(n, trust);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudgeTest5()
        {

            // arrange
            int n = 4;
            var trust = new int[][] { new int[] { 1, 3 }, new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 2, 4 }, new int[] { 4, 3
            } };
            int expected = 3;

            // act
            int actual = new Solution().FindJudge(n, trust);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}