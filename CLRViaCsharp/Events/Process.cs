using System;
using System.Collections.Generic;
using System.Text;

namespace CLRViaCsharp.Events
{
    public sealed class Process
    {

        private Guid _id = Guid.NewGuid();
        private int _result;

        public Guid Id => _id;

        public int Result
        {
            get => _result;
            set => _result = value;
        }

        public Process()
        {
        }
        public Process(int result)
        {

            _result = result;
        }
    }
}
