using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CLRViaCsharp.ExplicitlyImplementingEvents.CLR_Way
{
    public class EventSet
    {
        private readonly Dictionary<EventKey, Delegate> _events =
            new Dictionary<EventKey, Delegate>();


        public void Add(EventKey key, Delegate handler)
        {
            Monitor.Enter(_events);

            _events.TryGetValue(key, out Delegate d);

            _events[key] = Delegate.Combine(d, handler);
            Monitor.Exit(_events);

        }

        public void Remove(EventKey key, Delegate handler)
        {
            if (_events.TryGetValue(key, out Delegate d))
            {
                d = Delegate.Remove(d, handler);
                if (d != null)
                    _events[key] = d;
                else
                    _events.Remove(key);

            }
        }

        public void Raise(EventKey key, object sender, EventArgs e)
        {
            Monitor.Enter(_events);
            _events.TryGetValue(key, out Delegate d);
            Monitor.Exit(_events);
            d?.DynamicInvoke(sender, e);
        }


    }
}
