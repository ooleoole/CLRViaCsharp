using System;

namespace CLRViaCsharp.Events.EventArgs
{
    public sealed class ProcessDoneEventArgs : System.EventArgs
    {
        private readonly DateTime _done;
        private readonly Process _process;

        public Process Process => _process;
        public DateTime Done => _done;

        public ProcessDoneEventArgs(DateTime done, Process process)
        {
            _done = done;
            _process = process;
        }

    }
}
