using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class Route
    {
        public string RouteID;
        public string Des;
        public string Dep;
        public string PermitionNo;

        public Route(string routeID, string des, string dep, string permitionNo)
        {
            RouteID = routeID;
            Des = des;
            Dep = dep;
            PermitionNo = permitionNo;
        }
    }
}
