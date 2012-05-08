using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PiticotBusiness.Classes.Cells
{
    public abstract class Cell : ICell
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public Image Img { get; set; }

        public abstract void Act(Game game);
    }
}
