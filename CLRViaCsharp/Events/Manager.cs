using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CLRViaCsharp.Events.EventArgs;

namespace CLRViaCsharp.Events
{
    internal sealed class Manager
    {
        private Collection<ProcessLog> _processLogs;
        public IEnumerable<ProcessLog> ProcessLogs => _processLogs;

        public Manager(ISubscribable processor)
        {
            _processLogs = new Collection<ProcessLog>();
            processor.ProcessStarted += LogProcessStart;
            processor.ProcessDone += LogProcessDone;
        }

        private void LogProcessDone(object sender, ProcessDoneEventArgs e)
        {
            Console.WriteLine($"Processor: {((Processor)sender).Id} finished process at {e.Done}\n");
            var log = _processLogs.FirstOrDefault(pl => pl.ProcessId == e.Process.Id);
            log.ProcessDone = e.Done;

        }

        private void LogProcessStart(object sender, ProcessStartedEventArgs e)
        {
            Console.WriteLine($"Processor: {((Processor)sender).Id} started process at: {e.Start}\n");
            _processLogs.Add(new ProcessLog((Processor)sender, e));
        }
    }


}
