using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CommandHistory
    {
        private readonly Stack<IUndoCommand> _commands;

        public CommandHistory()
        {
            _commands = new Stack<IUndoCommand>();
        }
        public void Push(IUndoCommand command)
        {
            _commands.Push(command);
        }
        public IUndoCommand? Pop()
        {
            return _commands.Count()>0 ? _commands.Pop() : null;
        }
    }
}
