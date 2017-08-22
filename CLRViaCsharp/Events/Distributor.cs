using System;
using CLRViaCsharp.Events.EventArgs;

namespace CLRViaCsharp.Events
{
    internal sealed class Distributor
    {
        public Distributor(Processor processor)
        {
            processor.ProcessDone += HandleIncomingProcess;
        }

        private void HandleIncomingProcess(object sender, ProcessDoneEventArgs eventArgs)
        {
            Console.WriteLine($"Finished process from Processor: {((Processor)sender).Id} at: {eventArgs.Done}\n" +
                              $"Result: {((Processor)sender).Result}\n" +
                              $"initializing Distribution");
        }
    }
}
