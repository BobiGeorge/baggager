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

        public BranchingConveyor()
        {
            nextNodes = new Node[3];
            flightIDs = new int[3];
        }

        public void AddNewConnection(Node target, PathFinder p)
        {
            int id = p.FindFinalDropOff(target, 0);
            for(int i = 0; i < nextNodes.Count(); i++)
            {
                if(nextNodes[i] == null)
                {
                    nextNodes[i] = target;
              //      flightIDs[i] = 
                    break;
                }
            }
        }
    }
}