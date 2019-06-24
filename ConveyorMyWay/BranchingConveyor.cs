using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class BranchingConveyor : Node
    {
        Node[] nextNodes;
        int[] flightIDs;

        Dictionary<int, Node> nextNodesDic;

        public BranchingConveyor()
        {
            nextNodes = new Node[3];
            flightIDs = new int[3];

            nextNodesDic = new Dictionary<int, Node>();
        }

        public void AddNewConnection(Node target, PathFinder p)
        {

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
    }
}