using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void KillProcessTest1()
        {
            // arrange
            var pid = new int[] { 1, 3, 10, 5 };
            var ppid = new int[] { 3, 0, 5, 3 };
            int kill = 5;
            var solution = new Solution();

            // act
            var actual = solution.KillProcess(pid, ppid, kill).ToArray<int>();

            // assert
            Assert.AreEqual(2, actual.Length);
            Assert.AreEqual(5, actual[0]);
            Assert.AreEqual(10, actual[1]);
        }

        [TestMethod()]
        public void KillProcessTest2()
        {
            // arrange
            var pid = new int[] { 1, 2, 3 };
            var ppid = new int[] { 0, 1, 2 };
            int kill = 1;
            var solution = new Solution();

            // act
            var actual = solution.KillProcess(pid, ppid, kill).ToArray<int>();

            // assert
            Assert.AreEqual(3, actual.Length);
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(2, actual[1]);
            Assert.AreEqual(3, actual[2]);
        }
    }
}