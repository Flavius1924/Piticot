using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PiticotBusiness.Classes.Cells;
using System.Drawing;

namespace PiticotBusiness.Classes
{
    public class Player
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public bool HasWon { get; set; }
        public bool HasLost { get; set; }
        public Cell CurrentCell { get; internal set; }
        public int PreviousCellNumber { get; internal set; }
        public Color Color { get; set; }
    }
}
