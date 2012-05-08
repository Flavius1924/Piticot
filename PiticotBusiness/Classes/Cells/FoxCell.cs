using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class FoxCell : Cell
    {
        public FoxCell()
        {
            this.Name = "Vulpea";
            this.Message = "Vulpea te intoarce 3 pasi!";
            this.Img = Properties.Resources.fox;
        }

        public override void Act(Game game)
        {
            game.Move(-3);
        }
    }
}
//vulpea te intoarce la un alt numar decat lupul