using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class CheckIn : Node
    {
        List<Baggage> baggages;

        public CheckIn()
        {
            baggages = new List<Baggage>();
        }

        public void SendFirstBaggage()
        {
            if (baggages.Any() && baggageHeld == null)
                baggageHeld = baggages.First();
                baggages.RemoveAt(0);
        }
    }
}
