using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class DragonCell:Cell
    {
        public DragonCell() 
        {
            this.Name = "Dragonul";
        }

        public override void Act(Game game)
        {
            game.Move(4);
        }
    }
}
//dragonul te invinge si te intorci la casuta nr 1;