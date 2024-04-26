using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ChangeFirstNameCommand : ICommand, IUndoCommand
    {
        private readonly Models.Person _person;
        private readonly CommandHistory _commands;
        private string? _previousFirstName;

        public ChangeFirstNameCommand(Models.Person person, CommandHistory commands)
        {
            _person = person;
            _commands = commands;
        }

        public void Execute()
        {
            _previousFirstName = _person.FirstName;

            _person.FirstName = new Bogus.Faker("vi").Person.FirstName;

            _commands.Push(Clone());
            Print(_person);
        }

        private IUndoCommand Clone()
        {
            var clone = new ChangeFirstNameCommand(_person,_commands);
            clone._previousFirstName = _previousFirstName;
            return clone;
        }

        public void Undo()
        {
            if(_previousFirstName != null)
            {
                _person.FirstName = _previousFirstName;
            }
            Print(_person);
        }
        private void Print(Models.Person person)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(person);
            Console.ResetColor();
        }
    }
}
