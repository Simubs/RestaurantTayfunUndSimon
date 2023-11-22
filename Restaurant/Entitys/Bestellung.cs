using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entitys
{
    public class Bestellung
    {
        public Bestellung(int bestellNr, String rechnungNr,int TischNr ,KartenElement kartenElement, int kartenElementNr, string hinweise, DateTime AufgebenAm, bool erledigt,int GaesteNr)
        {
            BestellNr = bestellNr;
            RechnungNr = rechnungNr;
            KartenElement = kartenElement;
            KartenElementNr = kartenElementNr;
            this.Hinweise = hinweise;
            this.TischNr = TischNr;
            this.Erledigt = erledigt;  
            this.AufgegebenAm = AufgebenAm;
            this.GaesteNr = GaesteNr;
        }


        public int BestellNr { get; set; }
        public String RechnungNr { get; set; }
        public int TischNr { get; set;}
        public int GaesteNr { get; set; }
        public KartenElement KartenElement {get;set;}
        public int KartenElementNr { get;set;}
        public string Hinweise { get; set; }
        public DateTime AufgegebenAm { get; set; }
        public bool Erledigt { get; set;}
    }
}
