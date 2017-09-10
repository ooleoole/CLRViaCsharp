using System;
using System.ComponentModel;
using CLRViaCsharp.ExplicitlyImplementingEvents.CLR_Way;

namespace CLRViaCsharp.ExplicitlyImplementingEvents
{
    public class LotsOfEventsType
    {
        private static readonly object EventSomethingHappend = new object();
        private static readonly EventKey Key = new EventKey();
        private readonly EventHandlerList _events = new EventHandlerList();
        private readonly EventSet _eventsClrWay = new EventSet();

        public event EventHandler<EventArgs> DoSomethingImplicit;

        public event EventHandler<EventArgs> DoSomethingExplicit
        {
            add => _events.AddHandler(EventSomethingHappend, value);
            remove => _events.RemoveHandler(EventSomethingHappend, value);
        }

        public event EventHandler<EventArgs> DoSometingExlicitClrWay
        {
            add => _eventsClrWay.Add(Key, value);
            remove => _eventsClrWay.Remove(Key, value);
        }

        public void ImDoingIt()
        {
            Console.WriteLine("I did something");
            OnSomethingExplicit(EventArgs.Empty);
            OnSomethingImplicit(EventArgs.Empty);
            OnSomethingExplicitClr(EventArgs.Empty);

        }

        protected virtual void OnSomethingExplicit(EventArgs e) =>
            ((EventHandler<EventArgs>)_events[EventSomethingHappend])?.Invoke(this, e);

        protected virtual void OnSomethingImplicit(EventArgs e) =>
            DoSomethingImplicit?.Invoke(this, e);

        protected virtual void OnSomethingExplicitClr(EventArgs e) =>
            _eventsClrWay.Raise(Key, this, e);


    }

}
