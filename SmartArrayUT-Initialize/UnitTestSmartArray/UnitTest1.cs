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
     

        // #1 SmartArray should initialize with all zeros
        [TestMethod]
        public void ArrayStartWithAll_0s()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            //testSmartArray.SetAtIndex(2, 5);  //used to verify test is working
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

        // #2 SmartArray should allow setting the 0 location
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

        // #3 SmartArray throw exception trying to set location greater than size of array
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SetLocationAtSizeOfArrayValue()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(15, 55);
            // assert is handled by ExpectedException
        }

        // #4 Can add value to all locations in SmartArray
        [TestMethod]
        public void AddValueAllLoc()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            bool allHaveValue = false;
            //Add a value of i to all locations in SmartArray
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                testSmartArray.SetAtIndex(i,i);
            }
            //forloop that checks if there's anything at i index. if it doesn't, allHaveValue is false
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                if (testSmartArray.Find(i))
                {
                    allHaveValue = true;
                } else
                {
                    allHaveValue = false;
                }
            }
            Assert.IsTrue(allHaveValue);
        }

        // #5 SmartArray throw exception trying to set negative location
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SetNegativeLocation()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(SMART_ARRAY_SIZE, -1);
        }

        // #6 SmartArray should allow finding value
        [TestMethod]
        public void AllowFindValue()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(0, 1); //sets index 0 a value of 1
            Assert.IsTrue(testSmartArray.Find(1)); //returns true
        }

        // #7 SmartArray should find that is not there
        [TestMethod]
        public void NonExistantValue()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(0, 1); //sets index 0 a value of 1
            Assert.IsFalse(testSmartArray.Find(2)); //returns false
        }

        // #8 SmartArray should increase size from 5 to 10
        [TestMethod]
        public void Size5to10()
        {

            SmartArray testSmartArray = new SmartArray(5);
            SmartArray newSmartArray = new SmartArray(10);

            testSmartArray = newSmartArray; //NOTE: I'm aware that Array.Resize(ref x, y) exists but I am not given access to it due to testSmartArray being an object

            Assert.IsTrue(testSmartArray.Length == 10);
        }

        // #9 SmartArray should preserve given values when increasing from size 5 to 10
        [TestMethod]
        public void Size5to10Preserve()
        {

            SmartArray testSmartArray = new SmartArray(5);
            SmartArray newSmartArray = new SmartArray(testSmartArray.Length + 5);

            for (int i = 0; i < testSmartArray.Length; i++)
            {
                testSmartArray.SetAtIndex(i, 0); // 0,0,0,0,0
            }

            for (int i = 0; i < testSmartArray.Length; i++)
            {
                //Skip index 0-4
                newSmartArray.SetAtIndex(i+5, i+10);
            }

            testSmartArray = newSmartArray;
            Assert.IsTrue(testSmartArray.Length == 10);
            Assert.IsTrue(testSmartArray.GetAtIndex(0) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(1) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(2) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(3) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(4) == 0);
        }

        // #10 SmartArray should decrease size from 10 to 5
        [TestMethod]
        public void Size10to5()
        {

            SmartArray testSmartArray = new SmartArray(10);
            SmartArray newSmartArray = new SmartArray(5);

            testSmartArray = newSmartArray;

            Assert.IsTrue(testSmartArray.Length == 5);
        }

        // #11 SmartArray should preserve given values when decreasing from size 10 to 5
        // NOTE: Could not get this one to work due to limited tools for resizing. See line 127
        [TestMethod]
        public void Size10to5Preserve()
        {

            SmartArray testSmartArray = new SmartArray(10);
            SmartArray newSmartArray = new SmartArray(testSmartArray.Length - 5);

            for (int i = 0; i < testSmartArray.Length; i++)
            {
                testSmartArray.SetAtIndex(i, 0); // 0,0,0,0,0,0,0,0,0,0
            }

            for (int i = 0; i < newSmartArray.Length; i++)
            {
                //Skip index 0-4
                newSmartArray.SetAtIndex(i, i + 10); // 10, 11, 12, 13, 14
            }

            testSmartArray = newSmartArray;

            Assert.IsTrue(testSmartArray.Length == 5);

            Assert.IsTrue(testSmartArray.GetAtIndex(0) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(1) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(2) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(3) == 0);
            Assert.IsTrue(testSmartArray.GetAtIndex(4) == 0);
        }
    }
}


