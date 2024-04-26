using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ChangeLastNameCommand : ICommand, IUndoCommand
    {
        private readonly Models.Person _person;
        private readonly CommandHistory _commandHistory;

        private string? _previousLastName;

        public ChangeLastNameCommand(Models.Person person, CommandHistory commandHistory)
        {
            _person = person;
            _commandHistory = commandHistory;
        }

        public void Execute()
        {
            _previousLastName = _person.LastName;

            _person.LastName = new Bogus.Faker("vi").Person.LastName;
            Print(_person);
            _commandHistory.Push(Clone());
        }

        private IUndoCommand Clone()
        {
            var clone = new ChangeLastNameCommand(_person, _commandHistory);
            clone._previousLastName = _previousLastName;
            return clone;
        }

        private void Print(Person person)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(person);
            Console.ResetColor();
        }

        public void Undo()
        {
            if (_previousLastName != null)
            {
                _person.LastName = _previousLastName;
            }
            Print(_person);
        }
    }
}
