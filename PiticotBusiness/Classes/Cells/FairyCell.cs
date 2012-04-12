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
            this.Name = "Zana cea buna";
        }

        public override void Act(Game game)
        {
            //game.Move(2);
        }
    }
}
//zana cea buna te duce direct la finish la ultima casuta