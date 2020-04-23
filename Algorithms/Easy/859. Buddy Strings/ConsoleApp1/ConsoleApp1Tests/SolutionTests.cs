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
        public void BuddyStringsTest1()
        {
            // arrange
            string a = "ab";
            string b = "ba";

            // act
            bool actual = new Solution().BuddyStrings(a, b);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void BuddyStringsTest2()
        {
            // arrange
            string a = "ab";
            string b = "ab";

            // act
            bool actual = new Solution().BuddyStrings(a, b);

            // assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void BuddyStringsTest3()
        {
            // arrange
            string a = "aa";
            string b = "aa";

            // act
            bool actual = new Solution().BuddyStrings(a, b);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void BuddyStringsTest4()
        {
            // arrange
            string a = "aaaaaaabc";
            string b = "aaaaaaacb";

            // act
            bool actual = new Solution().BuddyStrings(a, b);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void BuddyStringsTest5()
        {
            // arrange
            string a = "";
            string b = "aa";

            // act
            bool actual = new Solution().BuddyStrings(a, b);

            // assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void BuddyStringsTest6()
        {
            // arrange
            string a = "abab";
            string b = "abab";

            // act
            bool actual = new Solution().BuddyStrings(a, b);

            // assert
            Assert.AreEqual(true, actual);
        }
    }
}