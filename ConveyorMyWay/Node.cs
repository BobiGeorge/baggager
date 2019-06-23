using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    abstract class Node
    {
        public Node nextNode;
        public bool justReceived;


        public Baggage baggageHeld;
    }
}
