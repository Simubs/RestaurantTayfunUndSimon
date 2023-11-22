using Restaurant.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows;
using System.Xml.Serialization;
using System.IO;

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
        public static String RechnungDateiErsteller(String RechnungsNummer, double rechnungsTotalBetrag, double rechnungsTrinkgeldBetrag, Mitarbeiter mitarbeiter, List<Bestellung> bestellungs) {
            String rechnungHeader = "<!DOCTYPE html><html><title>Rechnung</title><body><h1 style=\"text-align: left;\"><strong>&nbsp; &nbsp; &nbsp; Restaurantname </strong>" +
                    "</h1><p style=\"text-align: left;\">  40724 Hilden - Am Holterköpchen 34 </p>" +
                    "<p style=\"text-align: left;\"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Telefon: 02373 - 1234 </p>" +
                    "<p style=\"text-align: left;\"> ************************************</p>" +
                    "<h2 style=\"text-align: left;\"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Rechnung NR.</h2>" +
                    "<p style=\"text-align: left;\"> &nbsp;  " + RechnungsNummer + "</p>"+
                    "<p style=\"text-align: left;\">====================================</p>";
            String rechnungKoerper = null;
            for (int i = 0;i < bestellungs.Count; ++i)
            {
                rechnungKoerper += "<p style=\"text-align: left;\"> " + bestellungs[i].KartenElement.ElemName +"   "+ bestellungs[i].KartenElement.Preis + "€ </p>" +
                    "<p style=\"text-align: left;\" > ------------------------------------</p>";
            }

            
            String rechnungsFuß = "<p style=\"text-align: left;\" >====================================</p>" +
                    "<p style=\"text-align: left;\"> Tolal "+ rechnungsTotalBetrag + "€</p>" +
                    "<p style=\"text-align: left;\"> Trinkgeld: "+ rechnungsTrinkgeldBetrag + "€</p>" +
                    "<h2 style=\"text-align: left;\"> Bar: "+(rechnungsTotalBetrag+rechnungsTrinkgeldBetrag)+"€</h2>"+
                    "<p>  Es bediente Sie "+mitarbeiter.nachname+"</p>" +
                    "<p> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Vielen Dank</p></body></html>";


            return rechnungHeader + rechnungKoerper + rechnungsFuß;

        }

        public static void ausgabeRechnung(String RechnungDatei, String rechnungsNr)
        {
            String pfad = @"..\..\Rechnungen\" + rechnungsNr+ ".html";
            File.WriteAllText( pfad, RechnungDatei);
        }





    }
}
