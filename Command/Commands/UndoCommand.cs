using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class UndoCommand : ICommand
    {
        private readonly CommandHistory _commands;

        public UndoCommand(CommandHistory commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            _commands.Pop()?.Undo();
        }
    }
}
