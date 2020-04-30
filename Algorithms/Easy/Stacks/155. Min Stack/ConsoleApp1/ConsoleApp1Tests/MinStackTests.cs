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
    public class MinStackTests
    {
        [TestMethod()]
        public void MinStackTest1()
        {
            // arrange
            var obj = new MinStack();
            
            // act
            obj.Push(-2);
            obj.Push(0);
            obj.Push(-3);
            int a1 = obj.GetMin();
            obj.Pop();
            int a2 = obj.Top();
            int a3 = obj.GetMin();

            // assert
            Assert.AreEqual(a1, -3);
            Assert.AreEqual(a2, 0);
            Assert.AreEqual(a3, -2);
        }

        [TestMethod()]
        public void MinStackTest2()
        {
            // arrange
            var obj = new MinStack();
                
            // act
            obj.Push(2147483646);
            obj.Push(2147483646);
            obj.Push(2147483647);
            obj.Top();
            obj.Top();
            obj.GetMin();
            obj.Pop();
            obj.GetMin();
            obj.Pop();
            obj.Push(2147483647);
            obj.Top();
            obj.GetMin();
            obj.Push(-2147483648);
            obj.Top();
            obj.GetMin();
            obj.Pop();
            obj.GetMin();
            

           
            // assert
        }
    }
}