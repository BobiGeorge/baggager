using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class Baggage
    {
        public bool justTransfered;
        public int flightID;

        public Baggage(int id)
        {
            flightID = id;
        }
    }
}
