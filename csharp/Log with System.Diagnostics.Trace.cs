using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        TextWriterTraceListener fileLog = new TextWriterTraceListener("log.txt");
        Trace.Listeners.Add(fileLog);
        Trace.Listeners.Add(new ConsoleTraceListener());

        Trace.WriteLine("Application started.");
        Trace.WriteLine("This is a log message.");

        Trace.Flush();
        fileLog.Close();
    }
}
