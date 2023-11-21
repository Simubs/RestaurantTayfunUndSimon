using Restaurant.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    class RechnungErsteller
    {

        public static Rechnung ErstelleRechnung(Bestellung bestellung, double trinkgeld, int personalNummer)
        {
            Rechnung ZuErstellendeRechnung = new Rechnung();
            ZuErstellendeRechnung.RechnungNr = System.Guid.NewGuid().ToString();
            ZuErstellendeRechnung.RechnungBetrag = bestellung.KartenElement.Preis * bestellung.Anzahl;
            ZuErstellendeRechnung.Trinkgeld = trinkgeld;
            ZuErstellendeRechnung.PersonalNr = personalNummer;
            return ZuErstellendeRechnung;
        }





    }
}
