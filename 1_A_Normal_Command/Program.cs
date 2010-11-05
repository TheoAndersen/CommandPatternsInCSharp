using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_A_Normal_Command
{
    /*
     * A normal command is about being able to encapsulate a method. This is done via. an interface
     * according to the GoF - design patterns book.
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

    public class Program
    {

        static void Main(string[] args)
        {
            WriteSomething(new WithSpacesCommand("spaces?"));

            WriteSomething(new WithBracketsCommand("brackets?"));

            Console.ReadKey();
        }

        public static void WriteSomething(Command HowToWrite)
        {
            HowToWrite.Execute();
        }
    }
}
