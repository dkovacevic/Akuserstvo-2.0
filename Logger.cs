using System;
using System.Collections.Generic;
using System.Text;

namespace Parovic.Akuserstvo
{
    public static class Logger
    {
        public static string Source { get; set; }

        static Logger()
        {
            Source = "Parovic";
        }

        public static void WriteEntry(string name, Exception e)
        {
            try
            {
                if (!System.Diagnostics.EventLog.SourceExists(Source))
                {
                    System.Diagnostics.EventLog.CreateEventSource(Source, "Application");
                }

                System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();
                eventLog.Source = Source;
                eventLog.WriteEntry(string.Format("{0}: {1}", name, e), System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        public static void WriteEntry(string message)
        {
            try
            {
                if (!System.Diagnostics.EventLog.SourceExists(Source))
                {
                    System.Diagnostics.EventLog.CreateEventSource(Source, "Application");
                }

                System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();
                eventLog.Source = Source;
                eventLog.WriteEntry(message);
            }
            catch
            { }
        }
    }
}
