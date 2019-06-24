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
        List<Flight> flights;

        public CheckIn()
        {
            baggages = new List<Baggage>();
            flights = new List<Flight>();
        }

        public void SendFirstBaggage()
        {
            if (baggages.Any() && baggageHeld == null)
            {
                baggageHeld = baggages.First();
                baggages.RemoveAt(0);
                justReceived = false;
            }
        }

        public void AddBaggage(Baggage b)
        {
            baggages.Add(b);
        }

        public void AddFlights(Flight f)
        {
            flights.Add(f);
        }
        public List<Flight> GetFlights()
        {
            return flights;
        }
    }
}
