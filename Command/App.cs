using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class App
    {
        private readonly ICommand _action1Command;
        private readonly ICommand _action2Command;
        private readonly ICommand _undoCommand;

        public App(ICommand action1Command, ICommand action2Command, ICommand undoCommand)
        {
            _action1Command = action1Command;
            _action2Command = action2Command;
            _undoCommand = undoCommand;
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Press one of the keys below to perform the corresponding action:");

                Console.BackgroundColor = ConsoleColor.Green;

                Console.WriteLine("A. Action 1");
                Console.WriteLine("B. Action 2");
                Console.WriteLine("C. Undo");

                Console.ResetColor();

                ConsoleKey action = Console.ReadKey().Key;
                Console.WriteLine();

                switch (action)
                {
                    case ConsoleKey.A:
                        _action1Command.Execute();
                        break;
                    case ConsoleKey.B:
                        _action2Command.Execute();
                        break;
                    case ConsoleKey.C:
                        _undoCommand.Execute();
                        break;
                }
            }
        }
    }
}
