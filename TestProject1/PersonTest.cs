using MekanikerVærksted;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonTest
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
        ///A test for TimerPrUge
        ///</summary>
        [TestMethod()]
        public void TimerPrUgeTest()
        {
            Person target = new Person(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.TimerPrUge;
            Assert.IsTrue(actual > 0);
        }

        /// <summary>
        ///A test for Navn
        ///</summary>
        [TestMethod()]
        public void NavnTest()
        {
            Person target = new Person(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Navn = expected;
            actual = target.Navn;
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for Adresse
        ///</summary>
        [TestMethod()]
        public void AdresseTest()
        {
            Person target = new Person(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Adresse = expected;
            actual = target.Adresse;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for BeregnUgeLøn
        ///</summary>
        [TestMethod()]
        public void BeregnUgeLønTest()
        {
            Person target = new Person(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.BeregnUgeLøn();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for Person Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest()
        {
            Person target = new Person();
            Assert.IsNotNull(target);
        }
    }
}
