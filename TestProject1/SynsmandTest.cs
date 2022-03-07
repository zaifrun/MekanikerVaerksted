﻿using MekanikerVærksted;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for SynsmandTest and is intended
    ///to contain all SynsmandTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SynsmandTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AntalSynPrUge
        ///</summary>
        [TestMethod()]
        public void AntalSynPrUgeTest()
        {
            Synsmand target = new Synsmand(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.AntalSynPrUge = expected;
            actual = target.AntalSynPrUge;
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for BeregnUgeLøn
        ///</summary>
        [TestMethod()]
        public void BeregnUgeLønTest()
        {
            Synsmand target = new Synsmand(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.BeregnUgeLøn();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for Synsmand Constructor
        ///</summary>
        [TestMethod()]
        public void SynsmandConstructorTest()
        {
            Synsmand target = new Synsmand();
            Assert.IsNotNull(target);
        }
    }
}
