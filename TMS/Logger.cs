
using System.Diagnostics;

namespace Module08
{
    public static class Logger
    {
        public static void Log(string message)
        {
            EventLog serviceEventLog = new EventLog();
            if(!EventLog.SourceExists("MyEventSource"))
            {
                EventLog.CreateEventSource("MyEventSource","MyEventLog");
            }
            serviceEventLog.Source = "MyEventSource";
            serviceEventLog.Log = "MyEventLog";
            serviceEventLog.WriteEntry(message);
        }
    }
}
