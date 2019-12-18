using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class Dispatcher : Person
    {
        public string LicNo;
        public string ExDate;
        public Dispatcher(string firstName, string lastName, string iD, string nID, string birthDate,string licNo) : base(firstName, lastName, iD, nID, birthDate)
        {
            LicNo = licNo;
        }
    }
}
