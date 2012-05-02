using PiticotBusiness.Classes.Dice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectPiticot
{
    
    
    /// <summary>
    ///This is a test class for GameDiceTest and is intended
    ///to contain all GameDiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameDiceTest
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
        ///A test for Throw
        ///</summary>
        [TestMethod()]
        public void ThrowTest()
        {
            GameDice_Accessor target = new GameDice_Accessor(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Throw();
            bool betwen1and6 = false;
            if (actual <= 6 && actual >= 1) betwen1and6 = true;
            Assert.IsTrue(betwen1and6);

        }

    }
}
