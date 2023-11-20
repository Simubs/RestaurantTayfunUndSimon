using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entitys
{
    class Rechnung
    {
        public string RechnungNr { get; set; }
        public double RechnungBetrag { get; set; }
        public double Trinkgeld { get; set; }
        public int PersonalNr { get; set; }
    }
}
