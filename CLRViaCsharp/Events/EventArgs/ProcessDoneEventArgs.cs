using System;

namespace CLRViaCsharp.Events.EventArgs
{
    public sealed class ProcessDoneEventArgs :System.EventArgs
    {
        private readonly DateTime _done;

        public DateTime Done => _done;

        public ProcessDoneEventArgs(DateTime done)
        {
            _done = done;
        }

    }
}
