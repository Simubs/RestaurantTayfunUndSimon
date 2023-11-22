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

        public static Rechnung ErstelleRechnung(double Betrag ,double trinkgeld, int personalNummer)
        {
            Rechnung ZuErstellendeRechnung = new Rechnung();
            ZuErstellendeRechnung.RechnungNr = System.Guid.NewGuid().ToString();
            ZuErstellendeRechnung.RechnungBetrag = Betrag;
            ZuErstellendeRechnung.Trinkgeld = trinkgeld;
            ZuErstellendeRechnung.PersonalNr = personalNummer;
            ZuErstellendeRechnung.Datum = DateTime.Today.ToLongDateString();
            return ZuErstellendeRechnung;
        }





    }
}
