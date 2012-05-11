using PiticotBusiness.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProjectPiticot
{
    
    
    /// <summary>
    ///This is a test class for GameTest and is intended
    ///to contain all GameTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameTest
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
        ///A test for GenerateCells
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PiticotBusiness.dll")]
        public void GenerateCellsTest()
        {
            PrivateObject param0 = new PrivateObject(new Game(new List<Player>())); 
            Game_Accessor target = new Game_Accessor(param0);
            int actualCount = 60;
            Assert.AreEqual(target.Cells.Count, actualCount);
        }

        /// <summary>
        ///A test for NextPlayer
        ///</summary>
        [TestMethod()]
        public void NextPlayerTest()
        {
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player { Name = "Mihai" });
            playerList.Add(new Player { Name = "Ionel" });
            playerList.Add(new Player { Name = "Test" });
            Game target = new Game(playerList); // TODO: Initialize to an appropriate value
            target.player_Changed += new EventHandler(target_player_Changed);
            target.NextPlayer();
            target.NextPlayer();
            string actualName = "Ionel";
            Assert.AreEqual(target.CurrentPlayer.Name, actualName);
        }

        void target_player_Changed(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///A test for Move
        ///</summary>
        [TestMethod()]
        public void MoveTest()
        {
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player { Name = "Mihai" });
            playerList.Add(new Player { Name = "Ionel" });
            playerList.Add(new Player { Name = "Test" });
            Game target = new Game(playerList); // TODO: Initialize to an appropriate value
            target.player_Changed += new EventHandler(target_player_Changed);
            target.game_Move += new EventHandler(target_game_Move);
            int numberOfSteps = 2; // TODO: Initialize to an appropriate value
            target.NextPlayer();
            target.Move(numberOfSteps);
            Assert.IsTrue(target.CurrentPlayer.CurrentCell.Number == numberOfSteps);
        }

        void target_game_Move(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
