using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class LunchCell: Cell
    {
        public LunchCell()
        {
            this.Name = "Pranzul";
        }

        public override void Act(Game game)
        {
            game.Move(0);
        }
    }
}
//cik aici stai o tura la cina