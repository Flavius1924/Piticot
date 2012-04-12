using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class GapCell: Cell
    {
        public GapCell()
        {
            this.Name="Prapastia";
        }

        public override void  Act(Game game)
        {
 	        //game.Move(3);
        }
    }
}
//Daca pici pe prapastie pierzi direct 