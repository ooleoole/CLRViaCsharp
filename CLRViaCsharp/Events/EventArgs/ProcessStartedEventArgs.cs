using System;

namespace CLRViaCsharp.Events.EventArgs
{
    public sealed class ProcessStartedEventArgs : System.EventArgs
    {

        private readonly DateTime _start;

        public DateTime Start => _start;

        public ProcessStartedEventArgs(DateTime start)
        {
            _start = start;
        }
    }
}
