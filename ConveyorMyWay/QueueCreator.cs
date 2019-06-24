using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class QueueCreator
    {
        List<Baggage> baggages;

        public QueueCreator()
        {
            baggages = new List<Baggage>();
        }

        public void AddBaggage(Baggage b)
        {
            baggages.Add(b);
        }
        public List<Baggage> ReturnBaggages()
        {
            return baggages;
        }

        public void SendToCheckIn(List<CheckIn> checkIns)
        {
            if(baggages.Any() == false || checkIns.Any() == false)
            {
                return;
            }
            List<CheckIn> sendTargets = new List<CheckIn>();
            foreach(CheckIn ch in checkIns)
            {
                foreach(Flight f in ch.GetFlights())
                {
                    if(baggages[0].flightID == f.FlightID)
                    {
                        sendTargets.Add(ch);
                    }
                }
            }
            if(sendTargets.Any() == false)
            {
                return;
            }
            Random rnd = new Random();
            int i = rnd.Next(0, sendTargets.Count);
            sendTargets[i].AddBaggage(baggages[0]);
            baggages.RemoveAt(0);
        }
    }
}
