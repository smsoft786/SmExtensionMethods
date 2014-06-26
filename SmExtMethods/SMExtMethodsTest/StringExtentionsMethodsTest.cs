﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmExtentionsMethods;
namespace SMExtMethodsTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class StringExtentionsMethodsTest
    {
        public StringExtentionsMethodsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TypeConverstionTest()
        {
            // try to convert '1234' into int
            int i = "1234".toInt() ?? 0;
            Assert.AreEqual(i, 1234);
            i = "a1234".toInt() ?? 0;
            Assert.AreEqual(i, 0);

            // try to convert '0123' to decimal
            decimal d = "0123".toDecimal() ?? 0;
            Assert.AreEqual(d, 0123);
            d = "0a123".toDecimal() ?? 1;
            Assert.AreEqual(d, 1);

        }
    }
}
