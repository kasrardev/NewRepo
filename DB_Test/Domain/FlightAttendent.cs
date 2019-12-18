using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class FlightAttendent : Person
    {
        public Medical Medical;
        public string Type;
        public string Post;
        public FlightAttendent(string firstName, string lastName, string iD, string nID, string birthDate,Medical medical) : base(firstName, lastName, iD, nID, birthDate)
        {
            Medical = medical;
        }
    }
}
