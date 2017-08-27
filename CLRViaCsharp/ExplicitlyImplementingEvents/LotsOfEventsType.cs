using System;
using System.ComponentModel;

namespace CLRViaCsharp.ExplicitlyImplementingEvents
{
    public class LotsOfEventsType
    {
        private static readonly object EventSomethingHappend = new object();
        private readonly EventHandlerList _events = new EventHandlerList();

        public event EventHandler<EventArgs> DoSomethingImplicit;
        public event EventHandler<EventArgs> DoSomethingExplicit
        {
            add => _events.AddHandler(EventSomethingHappend, value);
            remove => _events.RemoveHandler(EventSomethingHappend, value);
        }

        public void ImDoingIt()
        {
            Console.WriteLine("I did some thing");
            OnSomethingExplicit(EventArgs.Empty);
            OnSomethingImplicit(EventArgs.Empty);
        }
        protected virtual void OnSomethingExplicit(EventArgs e)=>
            ((EventHandler<EventArgs>)_events[EventSomethingHappend])?.Invoke(this, e);

        protected virtual void OnSomethingImplicit(EventArgs e) =>
            DoSomethingImplicit?.Invoke(this, e);
    }

}
