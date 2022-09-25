using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartArrayLibrary;
using System;

namespace UnitTestProjectSmartArray
{
    [TestClass]
    public class UnitTest1
    {
        const int SMART_ARRAY_SIZE = 5;
        // SmartArray should initialize with all zeros
        [TestMethod]
        public void ArrayStartWithAll_0s()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(2, 5);  //used to verify test is working
            int actual = 0;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                actual = actual + testSmartArray.GetAtIndex(i);
            }
            // assert
            int expected = 0;
            Assert.AreEqual(expected, actual, 0.000001, "SmartArray not initilized to all zeros");
        }
        // SmartArray should allow setting the 0 location
        [TestMethod]
        public void SetLocation_0()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(0, 5);
            // assert
            int actual = testSmartArray.GetAtIndex(0);
            int expected = 5;
            Assert.AreEqual(expected, actual, 0.000001, "Did not set SmartArray loc 0 correctly");
        }
    }
}
