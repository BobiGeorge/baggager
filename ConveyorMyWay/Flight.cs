using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class Flight
    {
        public int FlightID;

        public Flight(int id)
        {
            FlightID = id;
        }
        public override string ToString()
        {
            return "Flight ID: " + FlightID; 
        }
    }
}
