using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_CompositeCommand_Is_An_Event
{
    /*
     * The c# event is acrually just an implementation of the Composite Command pattern
     * build into C#.. Although you'l notice a difference between the last composite command exemple 
     * if you look closely.
     * 
     * In the last example we utilized the objects encapsulating the method, to inject the string to 
     * be written in the constructor. When encapsulating methods as we do here, we have no constructor
     * and this we inject the input on the method. Therefore each of the two commands is run with
     * the same input.
     * 
     * This would be the same if we had in the interface-based command examples, injected the value on the
     * execute methods instead
     * 
     * eg:
     * 
     *  public class WithBracketsCommand : Command
        {
            public void Execute(string input)
            {
                Console.Write("Commandpattern with brackets: [" + input + "]" + Environment.NewLine);
            }
        }
     * 
     * 
     */

    public delegate void Command(string input);

    public class Program
    {
        static event Command commandEvent;

        static void Main(string[] args)
        {
            commandEvent += new Command(WithSpacesCommand);
            commandEvent += new Command(WithBracketsCommand);

            commandEvent("Spaces?");

            Console.ReadKey();
        }

        public static void WithSpacesCommand(string input)
        {
            Console.Write("Commandpattern with spaces: (" + input + ")" + Environment.NewLine);
        }

        public static void WithBracketsCommand(string input)
        {
            Console.Write("Commandpattern with brackets: [" + input + "]" + Environment.NewLine);
        }
    }
}
