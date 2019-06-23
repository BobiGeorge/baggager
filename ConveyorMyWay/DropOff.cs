using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class DropOff : Node
    {
        public int FlightID;

        List<Baggage> baggages;

        public DropOff()
        {
            baggages = new List<Baggage>();
        }

        public void ReceiveBaggage()
        {
            if (baggageHeld != null)
            {
                baggages.Add(baggageHeld);
                baggageHeld = null;
            }
        }
    }
}
