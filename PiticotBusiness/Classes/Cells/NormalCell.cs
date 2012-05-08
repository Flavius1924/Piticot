using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class NormalCell : Cell
    {
        public NormalCell()
        {
            this.Name = "Normala";
            this.Img = null;
        }

        public override void Act(Game game)
        {
            return;
        }
    }
}
