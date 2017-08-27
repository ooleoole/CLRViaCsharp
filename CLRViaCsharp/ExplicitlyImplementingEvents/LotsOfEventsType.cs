using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace CLRViaCsharp.ExplicitlyImplementingEvents
{
    public class LotsOfEventsType
    {
        private static readonly object EventSomethingHappend = new object();
        private EventHandlerList _events = new EventHandlerList();
        public event EventHandler SomethingHappend
        {
            add => _events.AddHandler(EventSomethingHappend, value);
            remove => _events.RemoveHandler(EventSomethingHappend, value);
        }

        public void ImDoingIt()
        {
            Console.WriteLine("I did some thing");
            OnSomeThingHappend(EventArgs.Empty);
        }
        protected virtual void OnSomeThingHappend(EventArgs e)=>
            ((EventHandler)_events[EventSomethingHappend])?.Invoke(this, e);
        
    }

}
