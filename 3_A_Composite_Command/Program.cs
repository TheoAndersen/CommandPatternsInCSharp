using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_A_Composite_Command
{
    /*
     * If we wanted to execute multiple operations at once, and still have them encapsulated 
     * as with the command we could make a composite command.
     */

    public interface Command
    {
        void Execute();
    }

    public class WithSpacesCommand : Command
    {
        string input;

        public WithSpacesCommand(string input)
        {
            this.input = input;
        }

        public void Execute()
        {
            Console.Write("Commandpattern with spaces: (" + input + ")" + Environment.NewLine);
        }
    }

    public class WithBracketsCommand : Command
    {
        string input;

        public WithBracketsCommand(string input)
        {
            this.input = input;
        }

        public void Execute()
        {
            Console.Write("Commandpattern with brackets: [" + input + "]" + Environment.NewLine);
        }
    }

    public class CompositeCommand : Command
    {
        List<Command> commands;

        public CompositeCommand()
        {
            commands = new List<Command>();
        }

        public void Add(Command command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach (Command command in commands)
            {
                command.Execute();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            CompositeCommand doMultipleThings = new CompositeCommand();
            doMultipleThings.Add(new WithSpacesCommand("spaces?"));
            doMultipleThings.Add(new WithBracketsCommand("brackets?"));

            WriteSomething(doMultipleThings);

            Console.ReadKey();
        }

        public static void WriteSomething(Command HowToWrite)
        {
            HowToWrite.Execute();
        }
    }
}
