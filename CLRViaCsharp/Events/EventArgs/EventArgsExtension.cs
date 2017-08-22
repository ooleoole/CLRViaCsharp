using System;
using System.Threading;

namespace CLRViaCsharp.Events.EventArgs
{
    public static class EventArgsExtension
    {

        public static void Raise<TEventArgs>(this TEventArgs e, object sender,
            ref EventHandler<TEventArgs> eventDelegate)
        {
            var temp = Volatile.Read(ref eventDelegate);
            temp?.Invoke(sender, e);
        }
    }
}
