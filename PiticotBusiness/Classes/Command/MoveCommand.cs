using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Command
{
    public class MoveCommand : UndoableCommand
    {
        private Game game;
        private int steps;
        private int previousPosition;
        private Player previousPlayer;

        public MoveCommand(Game game, int steps)
        {
            this.game = game;
            this.steps = steps;
            previousPosition = game.CurrentPlayer.CurrentCell.Number;
            previousPlayer = game.CurrentPlayer;
        }

        public override void Undo()
        {
            
        }

        public override void Execute()
        {

        }
    }
}
