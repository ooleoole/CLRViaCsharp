using System;

namespace CLRViaCsharp.ExplicitlyImplementingEvents
{
    public class RespondToEvent
    {

        public RespondToEvent(LotsOfEventsType lotsOfEvents)
        {
            lotsOfEvents.SomethingHappend += DoSomething;
        }

        private void DoSomething(object sender, EventArgs e)
        {
            Console.WriteLine("Im doing something");
        }
    }
}
