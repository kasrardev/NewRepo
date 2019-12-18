using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class Flight
    {
        public string FlightNO;
        public string PAX_NO;
        public string TakeOff;
        public string Landing;
        public string BlockOut;
        public String BlockIn;

        public Flight(string flightNO, string pAX_NO, string takeOff, string landing, string blockIn, string blockOut)
        {
            FlightNO = flightNO;
            PAX_NO = pAX_NO;
            TakeOff = takeOff;
            Landing = landing;
            BlockIn = blockIn;
            BlockOut = blockOut;
        }
    }
}
