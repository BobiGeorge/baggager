using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class PathFinder
    {
        public int FindFinalDropOff(Node starter, int id)
        {
            if(id != 0)
            {
                return id;
            }
            if(starter.nextNode is DropOff)
            {
                DropOff d = starter.nextNode as DropOff;
                id = d.FlightID;
                return id;
            }
            if(starter.nextNode != null)
            {
                id = FindFinalDropOff(starter.nextNode, id);
            }
            return id;
        }
    }
}
