using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackClass;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // try the myStack.IsEmpty_empty() property
        public void IsEmptyPropEmpty()
        {
            OurStack testStack = new OurStack(10);
            Assert.AreEqual(true, testStack.IsEmpty());
        }

        [TestMethod]
        // try the myStack.IsEmpty_notempty() property
        public void IsEmptyPropNotEmpty()
        {
            OurStack testStack = new OurStack(10);
            testStack.Push(77);
            Assert.AreEqual(false, testStack.IsEmpty());
        }

        [TestMethod]
        // try the myStack.IsEmpty_empty() property after pushing and popping
        public void IsEmptyAfterPopPropEmpty()
        {
            OurStack testStack = new OurStack(10);
            testStack.Push(77);
            testStack.Pop();
            Assert.AreEqual(true, testStack.IsEmpty());
        }

        [TestMethod]
        // try the OverflowException when no room left in backing array
        [ExpectedException(typeof(OverflowException))]
        public void OverflowExceptionTest()
        {
            OurStack testStack = new OurStack(3);
            testStack.Push(77);
            testStack.Push(77);
            testStack.Push(77);
            testStack.Push(77);
        }

        [TestMethod]
        // try the IndexOutOfRangeException when try and pop and empty stack

        public void IndexOutOfRangeExceptionTest()
        {

        }

        [TestMethod]
        // do not let test catch it[ExpectedException(typeof(OverflowException.))]
        // try the OverflowException when no room left in backing array, test message
        public void OverflowExceptionMessage()
        {
            OurStack testStack = new OurStack(3);
            testStack.Push(77);
            testStack.Push(77);
            testStack.Push(77);
            string actual = "";
            try
            {
                testStack.Push(77);
            }
            catch (OverflowException ex)
            {

                actual = ex.Message;
            }

            finally
            {
                string expected = "Stack is full";
                Assert.AreEqual<string>(actual, expected);
            }

        }

        [TestMethod]
        // try the myStack.Peek() method
        public void PeekTest()
        {

        }

        [TestMethod]
        // try the myStack.Peek() method again to make sure still there
        public void PeekAgainTest()
        {

        }

        [TestMethod]
        //empty the stack
        public void EmptyStackTest()
        {

        }



    }
}


