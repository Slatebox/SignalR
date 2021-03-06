﻿namespace SignalR.ServiceBus
{
    using System.Collections.Generic;
    using System.Diagnostics;

    static class TraceEventTypeExtentionMethods
    {
        static readonly Dictionary<TraceEventType, string> TraceEventTypeToStringMap =
            new Dictionary<TraceEventType, string>
            {
                { TraceEventType.Critical, "Critical" },
                { TraceEventType.Error, "Error" },
                { TraceEventType.Information, "Information" },
                { TraceEventType.Resume, "Resume" },
                { TraceEventType.Start, "Start" },
                { TraceEventType.Stop, "Stop" },
                { TraceEventType.Suspend, "Suspend" },
                { TraceEventType.Transfer, "Transfer" },
                { TraceEventType.Verbose, "Verbose" },
                { TraceEventType.Warning, "Warning" },
            };

        public static string ToStringFast(this TraceEventType eventType)
        {
            return TraceEventTypeToStringMap[eventType];
        }
    }
}
