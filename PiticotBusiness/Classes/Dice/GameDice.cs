using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Dice
{
    internal class GameDice
    {
        #region Singleton
        private GameDice() { }
        private static GameDice dice = null;
        public static GameDice GetInstance()
        {
            if (dice == null) dice = new GameDice();
            return dice;
        }

        #endregion

        public int Throw()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
