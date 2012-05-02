using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Cells
{
    internal class WolfCell : Cell
    {
        public WolfCell()
        {
            this.Name = "Lupul";
            this.Message = "Lupul te intoarce 4 pasi!";
        }

        public override void Act(Game game)
        {
            game.Move(-4);
        }
    }
}

//la un numar care vrem noi sau cate casute vrem noi