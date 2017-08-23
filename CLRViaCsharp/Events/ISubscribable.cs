using System;
using CLRViaCsharp.Events.EventArgs;

namespace CLRViaCsharp.Events
{
    internal interface ISubscribable
    {
        event EventHandler<ProcessDoneEventArgs> ProcessDone;
        event EventHandler<ProcessStartedEventArgs> ProcessStarted;
    }
}