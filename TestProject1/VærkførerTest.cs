using MekanikerVærksted;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for VærkførerTest and is intended
    ///to contain all VærkførerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VærkførerTest
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
        ///A test for Ugetillæg
        ///</summary>
        [TestMethod()]
        public void UgetillægTest()
        {
            Værkfører target = new Værkfører(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Ugetillæg = expected;
            actual = target.Ugetillæg;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for Udnævnelsesår
        ///</summary>
        [TestMethod()]
        public void UdnævnelsesårTest()
        {
            Værkfører target = new Værkfører(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Udnævnelsesår = expected;
            actual = target.Udnævnelsesår;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for BeregnUgeLøn
        ///</summary>
        [TestMethod()]
        public void BeregnUgeLønTest()
        {
            Værkfører target = new Værkfører(); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.BeregnUgeLøn();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for Værkfører Constructor
        ///</summary>
        [TestMethod()]
        public void VærkførerConstructorTest()
        {
            Værkfører target = new Værkfører();
            Assert.IsNotNull(target);
        }
    }
}
