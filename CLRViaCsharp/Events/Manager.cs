using System;
using CLRViaCsharp.Events.EventArgs;

namespace CLRViaCsharp.Events
{
    internal sealed class Manager
    {
        public Manager(Processor processor)
        {
            processor.ProcessStarted += LogProcess;
        }

        private void LogProcess(object sender, ProcessStartedEventArgs e)
        {
            Console.WriteLine($"Processor: {((Processor)sender).Id} started process at: {e.Start}\n");
        }
    }
}
