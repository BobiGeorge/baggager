﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class Engine
    {
        List<CheckIn> checkIns;
        List<Conveyor> conveyors;
        List<DropOff> dropOffs;
        List<BranchingConveyor> branchingConveyors;

        public Engine()
        {
            checkIns = new List<CheckIn>();
            conveyors = new List<Conveyor>();
            dropOffs = new List<DropOff>();
            branchingConveyors = new List<BranchingConveyor>();
        }
        public void Move()
        {
            SetBranchDirections();
            ReceiveFromDropOff();
            SendToCheckIns();
            MoveNodes(conveyors);
            MoveNodes(checkIns);    
        }

        private void SendToCheckIns()
        {
            foreach(CheckIn c in checkIns)
            {
                c.SendFirstBaggage();
            }
        }

        private void ReceiveFromDropOff()
        {
            foreach(DropOff d in dropOffs)
            {
                d.ReceiveBaggage();
            }
        }

        private void SetBranchDirections()
        {
            foreach(BranchingConveyor bc in branchingConveyors)
            {
                bc.SetBaggageDirection();
            }
        }

        private void ConnectBranches()
        {

        }

        public void MoveNodes<T>(List<T> moveList) where T : Node
        {
            foreach(Node c in moveList)
            {
                if(c.nextNode != null && c.justReceived == false)
                {
                    if(c.baggageHeld != null && c.nextNode.baggageHeld == null)
                    {
                        c.nextNode.baggageHeld = c.baggageHeld;
                        c.baggageHeld = null;
                        c.nextNode.justReceived = true;
                    }
                }
                c.justReceived = false;
            }
        }
        public void MoveBranchingConveyor()
        {

        }

        public Conveyor firstConveyor()
        {
            return conveyors.First();
        }

        public void ConnectNodes(Node selected, Node target)
        {
            selected.nextNode = target;
        }

        public List<Conveyor> GetConveyors()
        {
            return conveyors;
        }

        public Conveyor AddConveyor()
        {
            Conveyor c = new Conveyor();
            conveyors.Add(c);
            return c;
        }
        public Node AddNode(string buildType)
        {
            switch (buildType)
            {
                case "Conveyor":
                    Conveyor co = new Conveyor();
                    conveyors.Add(co);
                    return co;
                case "CheckIn":
                    CheckIn ch = new CheckIn();
                    checkIns.Add(ch);
                    return ch;
                case "DropOff":
                    DropOff dr = new DropOff();
                    dropOffs.Add(dr);
                    return dr;
                case "Branch":
                    BranchingConveyor br = new BranchingConveyor();
                    branchingConveyors.Add(br);
                    return br;
            }
            return null;
        }
    }
}
