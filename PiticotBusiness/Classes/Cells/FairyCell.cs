using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class FairyCell: Cell
    {
        public FairyCell()
        {
            this.Name = "Zana";
            this.Message = "Felicitari! Zana te-a facut victorios!";
            this.Img = Properties.Resources.fairy;
        }

        public override void Act(Game game)
        {
            game.CurrentPlayer.HasWon = true;
            game.IsFinished = true;
            game.Move(0);
        }
    }
}
//zana cea buna te duce direct la finish la ultima casuta