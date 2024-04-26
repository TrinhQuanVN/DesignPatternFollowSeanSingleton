using Command;
using Command.Commands;

var person = new Command.Models.Person("Trinh", "Quan");

var commandHistory = new CommandHistory();

var app = new App(new ChangeFirstNameCommand(person, commandHistory),
    new ChangeLastNameCommand(person, commandHistory),
    new UndoCommand(commandHistory));
app.Run();