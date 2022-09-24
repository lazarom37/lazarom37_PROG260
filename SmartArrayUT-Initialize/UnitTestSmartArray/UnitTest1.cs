using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartArrayLibrary;

namespace UnitTestSmartArray
{
    [TestClass]
    public class UnitTest1
    {
        int SMART_ARRAY_SIZE;
        int someValue;

        [TestInitialize]  // do anything here that you need to be done for each test
        // note, this method will be run before EVERY test
        public void Init()
        {
            SMART_ARRAY_SIZE = 5;
            someValue = 100;
        }
     

        // SmartArray should initialize with all zeros
        [TestMethod]
        public void ArrayStartWithAll_0s()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            // testSmartArray.SetAtIndex(2, 5);  //used to verify test is working
            int actual = 0;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                actual = actual + testSmartArray.GetAtIndex(i);
            }
            int expected = 0;
            Assert.AreEqual(expected, actual, 0.000001, "SmartArray not initilized to all zeros");

            int expected2 = 3;
            someValue = 3;
            Assert.AreEqual(expected2, someValue, 0.000001, "Expected value of someValue not correct");

        }

        // SmartArray should allow setting the 0 location
        [TestMethod]
        public void SetLocation_0()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(0, 5);
            int actual = testSmartArray.GetAtIndex(0);
            int expected = 5;
            Assert.AreEqual(expected, actual, 0.000001, "Did not set SmartArray loc 0 correctly");

            int expected2 = 100;  
           // we are counting on someValue to be back at 100, and not 3 as set by previous test
            Assert.AreEqual(expected2, someValue, 0.000001, "Expected value of someValue not correct");

        }

        // SmartArray throw exception trying to set location greater than size of array
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SetLocationAtSizeOfArrayValue()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(15, 55);
            // assert is handled by ExpectedException
        }
        
    }
}
