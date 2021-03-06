﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_A_Delegate_Command
{
    /*
     * A Command in c# can a bit easier be represented as a delegate. 
     * This way we can call encapsulate the method directly, whereas a normal simple command
     * object would use an interface, to encapsulate an object with the method.
     * 
     * The use of a delegate though isnt as easily extended as with an interface
     * 
     */

    public delegate void Command(string input);

    public class Program
    {

        static void Main(string[] args)
        {
            WriteSomething("spaces?", new Command(WithSpacesCommand));
            
            WriteSomething("brackets?", new Command(WithBracketsCommand));

            Console.ReadKey();
        }

        public static void WriteSomething(string whatToWrite, Command HowToWrite)
        {
            HowToWrite(whatToWrite);
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
