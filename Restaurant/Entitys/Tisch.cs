using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entitys
{
    public class Tisch
    {
        public Tisch(int tischNr, int mitarbeiternummer, int sitzplaetze)
        {
            this.tischNr = tischNr;
            this.mitarbeiternummer = mitarbeiternummer;
            this.sitzplaetze = sitzplaetze;
        }

        public int tischNr { get; set; }
        public int mitarbeiternummer { get; set;}
        public int sitzplaetze {  get; set; }

    }
}
