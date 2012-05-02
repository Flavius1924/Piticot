using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class DwarfCell : Cell
    {
        public DwarfCell()
        {
            this.Name = "Piticul";
            this.Message = "Piticul te avanseaza 3 pasi!";
        }

        public override void Act(Game game)
        {
            game.Move(3);
        }

    }
}
