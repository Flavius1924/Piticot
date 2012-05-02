using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Command
{
    public class CommandManager
    {
        private Stack<Command> commands = new Stack<Command>();

        public void ExecuteCommand(Command cmd)
        {
            cmd.Execute();
            if (cmd is UndoableCommand)
            {
                commands.Push(cmd);
            }
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                UndoableCommand cmd = (UndoableCommand)commands.Pop();
                cmd.Undo();
            }
        }
    }
}
