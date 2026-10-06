using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Predicate_Delegate
{

    public delegate void Notify(string message);

    public delegate void LogHandler(string message);

    //  this Delegate used to sort the list of persons;
    public delegate int Comparison<T>(T x, T y);

    internal class Delegates
    {

        public Delegates()
        {
            Notify notifydelegate = ShowMessage;
            notifydelegate("Hello World");

            Logger logger = new Logger();
            LogHandler log = logger.LogToConsole;
            log("This is a log message");

            log = logger.LogToFile;
            log("This is another log message");
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }

    public class Logger {
    
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Log to console: {message}");
        }

        public void LogToFile(string message)
        {
            // Code to log to file
            Console.WriteLine($"Log to file: {message}");
        }

    }

    // Generic methd with delegate


}
