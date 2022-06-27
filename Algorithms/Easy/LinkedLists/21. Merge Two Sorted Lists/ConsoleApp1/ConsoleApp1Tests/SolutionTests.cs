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
        public void MergeTwoListsTest()
        {
            // arrange
            var l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);
            var l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            // act
            var solution = new Solution();
            var actual = solution.MergeTwoLists(l1, l2);

            // assert
       
            
            
            
           int a1 = actual.val;
            int a2 = actual.next.val;
            int a3 = actual.next.next.val;
            int a4 = actual.next.next.next.val;
            int a5 = actual.next.next.next.next.val;
            int a6 = actual.next.next.next.next.next.val;

            Assert.AreEqual(1, a1);
            Assert.AreEqual(1, a2);
            Assert.AreEqual(2, a3);
            Assert.AreEqual(3, a4);
            Assert.AreEqual(4, a5);
            Assert.AreEqual(4, a6);
        }

        [TestMethod()]
        public void MergeTwoListsTest2()
        {
            // arrange
            var l1 = new ListNode(1);
            
            var l2 = new ListNode(2);
            

            // act
            var solution = new Solution();
            var actual = solution.MergeTwoLists(l1, l2);

            // assert    

        }
    }
}