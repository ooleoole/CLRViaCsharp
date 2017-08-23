using System;
using CLRViaCsharp.Events.EventArgs;

namespace CLRViaCsharp.Events
{
    internal sealed class Distributor
    {
        public Distributor(ISubscribable processor)
        {
            processor.ProcessDone += HandleIncomingProcess;
        }

        private void HandleIncomingProcess(object sender, ProcessDoneEventArgs eventArgs)
        {
            Console.WriteLine($"Recived process from Processor: {((Processor)sender).Id} at: {DateTime.Now}\n" +
                              $"Result: {eventArgs.Process.Result}\n" +
                              $"initializing Distribution");
        }
    }
}
