using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class Medical
    {
        public string MedicNo;
        public string Limitation;
        public DateTime ExDate;
        public string Class;
        public string DR;

        public Medical(string medicNo, string limitation, DateTime exDate, string @class, string dR)
        {
            MedicNo = medicNo;
            Limitation = limitation;
            ExDate = exDate;
            Class = @class;
            DR = dR;
        }
    }
}
