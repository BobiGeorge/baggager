using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConveyorMyWay
{
    class FlightManager
    {
        List<Flight> flights;

        public FlightManager()
        {
            flights = new List<Flight>();
        }

        public bool AddFlight(int id, int baggageCount)
        {
            foreach(Flight f in flights)
            {
                if(f.FlightID == id)
                {
                    return false;
                }
            }
            flights.Add(new Flight(id, baggageCount));
            return true;
        }
        public List<Flight> GetFlights()
        {
            return flights;
        }
        public Flight GetFlightByID (int id)
        {
            foreach(Flight f in flights)
            {
                if(f.FlightID == id)
                {
                    return f;
                }
            }
            return null;
        }
    }
}
