using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class DwarfCell: Cell
    {
        public DwarfCell()
        {
            this.Name = "Piticul";
        }

        public override void Act(Game game)
        {
            game.Move(3);
        }

    }
}
//piticul te avanseaza la un numar care vrem noi