using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class BranchingConveyor : Node
    {

        Dictionary<int, Node> nextNodesDic;

        public BranchingConveyor()
        {
            nextNodesDic = new Dictionary<int, Node>();
        }

        public void AddNewConnection(Node target, PathFinder p)
        {

        }
        public Dictionary<int, Node> ReturnNextsDic()
        {
            return nextNodesDic;
        }
        public List<Node> ReturnNextNodes()
        {
            List<Node> temp = new List<Node>();
            foreach(var d in nextNodesDic)
            {
                temp.Add(d.Value);
            }
            return temp;
        }
        public void SetBaggageDirection()
        {
            if(baggageHeld != null)
            {
                foreach(var d in nextNodesDic)
                {
                    if(d.Key == baggageHeld.flightID)
                    {
                        nextNode = d.Value;
                        break;
                    }
                }
            }
        }
        public void AddNextToDictionary(int flightID, Node d)
        {
            nextNodesDic.Add(flightID, d);
        }
    }
}