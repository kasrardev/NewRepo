using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class AirPlane
    {
        public string Name;
        public string RegCo;
        public string ENG;
        public string Equipment;
        public int Chair1stNO;
        public int ChairBusNO;
        public int ChairEcoNO;
        public string TotFlightTime;
        public string TotBlockTime;

        public AirPlane(string name, string regCo, string eNG, string equipment, int chair1stNO, int chairBusNO, int chairEcoNO, string totFlightTime, string totBlockTime)
        {
            Name = name;
            RegCo = regCo;
            ENG = eNG;
            Equipment = equipment;
            Chair1stNO = chair1stNO;
            ChairBusNO = chairBusNO;
            ChairEcoNO = chairEcoNO;
            TotFlightTime = totFlightTime;
            TotBlockTime = totBlockTime;
        }
    }
}
