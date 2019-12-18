using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class Pilot : Person
    {
        public string TotFlightTime;
        public string LicNO;
        public string ExDate;
        public string TypeName;
        public string TypeExdate;
        public Medical Medical;
        public Pilot(string firstName, string lastName, string iD, string nID, string birthDate,Medical medical) : base(firstName, lastName, iD, nID, birthDate)
        {
            Medical = medical;
        }
    }
}
