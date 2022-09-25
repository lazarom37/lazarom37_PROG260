using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace UnitTestProjectStack
{
    [TestClass]
    public class UnitTest1
    {
        // verify that a newly created stack has no entries
        [TestMethod]
        public void IsInitialStackEmpty()
        {
            Stack TestStack = new Stack();
            int expected = 0;
            int actual = TestStack.Count;
            Assert.AreEqual(expected, actual, "stack was not zero length");
        }

        // does it show 3 after 3 pushes?
        [TestMethod]
        public void Push3()
        {
            Stack TestStack = new Stack();
            TestStack.Push(10);
            TestStack.Push(20);
            TestStack.Push(30);
            int expected = 0;
            int actual = TestStack.Count;
            Assert.AreEqual(expected, actual, "stack was not zero length");
        }

        // does peek work?
        [TestMethod]
        public void TestPeek()
        {
            Stack TestStack = new Stack();
            TestStack.Push(10);
            TestStack.Push(20);
            TestStack.Push(30);
            int expected = 0;
            int actual = (int)TestStack.Peek();
            Assert.AreEqual(expected, actual, "stack was not zero length");
        }
    }
}
