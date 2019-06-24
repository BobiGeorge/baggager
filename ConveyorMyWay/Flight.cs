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
        public int totalBaggagesCount;

        public Flight(int id, int count)
        {
            FlightID = id;
            totalBaggagesCount = count;
        }
        public override string ToString()
        {
            return "Flight ID: " + FlightID + ". Baggage: " + totalBaggagesCount; 
        }
    }
}
