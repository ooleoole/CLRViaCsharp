using System;
using System.Threading;
using CLRViaCsharp.Events.EventArgs;

namespace CLRViaCsharp.Events
{
    internal class Processor
    {
        private int _result;
        private Guid _id = Guid.NewGuid();

        public Guid Id => _id;
        public int Result => _result;
        public event EventHandler<ProcessStartedEventArgs> ProcessStarted;
        public event EventHandler<ProcessDoneEventArgs> ProcessDone;

        public void Process()
        {
            OnProcessStarted(new ProcessStartedEventArgs(DateTime.Now));
            Console.Write("Processing");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i % 2 == 0 ? "/" : "\\");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            _result = new Random().Next();
            OnProcessDone(new ProcessDoneEventArgs(DateTime.Now));

            
        }

        protected virtual void OnProcessDone(ProcessDoneEventArgs e) => e.Raise(this, ref ProcessDone);
        protected virtual void OnProcessStarted(ProcessStartedEventArgs e) => e.Raise(this, ref ProcessStarted);
    }
}

