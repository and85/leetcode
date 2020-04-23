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
        public void IsValidTest1()
        {
            // arrange
            string input = "()";

            // act
            bool actual = new Solution().IsValid(input);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            // arrange
            string input = "()[]{}";

            // act
            bool actual = new Solution().IsValid(input);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsValidTest3()
        {
            // arrange
            string input = "(]";

            // act
            bool actual = new Solution().IsValid(input);

            // assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void IsValidTest4()
        {
            // arrange
            string input = "([)]";

            // act
            bool actual = new Solution().IsValid(input);

            // assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void IsValidTest5()
        {
            // arrange
            string input = "{[]}";

            // act
            bool actual = new Solution().IsValid(input);

            // assert
            Assert.AreEqual(true, actual);
        }

        public void IsValidTest6()
        {
            // arrange
            string input = "[";

            // act
            bool actual = new Solution().IsValid(input);

            // assert
            Assert.AreEqual(false, actual);
        }
    }

    
}