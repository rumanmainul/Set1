using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteEventLogEntry("This is an entry in the event log by daveoncsharp.com");
            Console.ReadKey();
        }

        private static void WriteEventLogEntry(string message)
        {
            // Create an instance of EventLog
            System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();

            // Check if the event source exists. If not create it.
            if (!System.Diagnostics.EventLog.SourceExists("TestApplication"))
            {
                System.Diagnostics.EventLog.CreateEventSource("TestApplication", "Application");
            }

            // Set the source name for writing log entries.
            eventLog.Source = "TestApplication";

            // Create an event ID to add to the event log
            int eventID = 8;

            // Write an entry to the event log.
            eventLog.WriteEntry(message,
                                System.Diagnostics.EventLogEntryType.Error,
                                eventID);

            // Close the Event Log
            eventLog.Close();
        }
    }
}
