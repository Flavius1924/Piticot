using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class HogCell: Cell
    {
        public HogCell()
        {
            this.Name = "Mistretul";
        }

        public override void Act(Game game)
        {
            game.Move(0);
        }
    }
}
//ocolesti mistretul un pic si cik stai o tura