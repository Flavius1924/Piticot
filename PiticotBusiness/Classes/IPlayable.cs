using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes
{
    public interface IPlayable
    {
        List<Player> GeneratePlayers(string[] playerNames);
    }
}
