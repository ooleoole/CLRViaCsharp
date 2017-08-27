using System;

namespace CLRViaCsharp.ExplicitlyImplementingEvents
{
    public class ListenToEvent
    {

        public ListenToEvent(LotsOfEventsType lotsOfEvents)
        {
            //lotsOfEvents.DoSomethingImplicit += RespondToEvent;
            //lotsOfEvents.DoSomethingExplicit += RespondToEvent;
        }

        private void RespondToEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Im doing something");
        }
    }
}
