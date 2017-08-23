using System;

namespace CLRViaCsharp.Events.EventArgs
{
    public sealed class ProcessStartedEventArgs : System.EventArgs
    {
        private readonly Guid _processId;
        private readonly DateTime _start;

        public Guid ProcessId => _processId;
        public DateTime Start => _start;

        public ProcessStartedEventArgs(DateTime start, Process process)
        {
            _start = start;
            _processId = process.Id;
        }
    }
}
