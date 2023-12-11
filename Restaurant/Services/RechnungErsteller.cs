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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Diagnostics;

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
        public static String RechnungHTMLDateiErsteller(String RechnungsNummer, double rechnungsTotalBetrag, double rechnungsTrinkgeldBetrag, Mitarbeiter mitarbeiter, List<Bestellung> bestellungs) {
            String rechnungHeader = "<!DOCTYPE html><html><title>Rechnung</title><body><h1 style=\"text-align: center;\"><strong>Restaurantname </strong>" +
                    "</h1><p style=\"text-align: center;\">  40724 Hilden - Am Holterköpchen 34 </p>" +
                    "<p style=\"text-align: center;\"> Telefon: 02373 - 1234 </p>" +
                    "<p style=\"text-align: center;\"> ************************************</p>" +
                    "<h2 style=\"text-align: center;\"> Rechnung NR.</h2>" +
                    "<p style=\"text-align: center;\"> " + RechnungsNummer + "</p>"+
                    "<p style=\"text-align: center;\">====================================</p>";
            String rechnungKoerper = null;
            for (int i = 0;i < bestellungs.Count; ++i)
            {
                rechnungKoerper += "<p style=\"text-align: center;\"> " + bestellungs[i].KartenElement.ElemName +"   "+ bestellungs[i].KartenElement.Preis + "€ </p>" +
                    "<p style=\"text-align: center;\" > ------------------------------------</p>";
            }

            
            String rechnungsFuß = "<p style=\"text-align: center;\" >====================================</p>" +
                    "<p style=\"text-align: center;\"> Tolal " + rechnungsTotalBetrag + "€</p>" +
                    "<p style=\"text-align: center;\"> Trinkgeld: " + rechnungsTrinkgeldBetrag + "€</p>" +
                    "<h2 style=\"text-align: center;\"> Bar: " + (rechnungsTotalBetrag+rechnungsTrinkgeldBetrag)+"€</h2>"+
                    "<p style=\"text-align: center;\">  Es bediente Sie " + mitarbeiter.nachname+"</p>" +
                    "<p style=\"text-align: center;\"> Vielen Dank</p></body></html>";


            return rechnungHeader + rechnungKoerper + rechnungsFuß;

        }

        public static void ausgabeRechnung(String RechnungDatei, String rechnungsNr)
        {
            String pfad = Constants.Constants.RECHNUNG_DATEI_PFAD + rechnungsNr+ ".html";
            File.WriteAllText( pfad, RechnungDatei);
        }

        public static String RechnungTextDateiErsteller(String RechnungsNummer, double rechnungsTotalBetrag, double rechnungsTrinkgeldBetrag, Mitarbeiter mitarbeiter, List<Bestellung> bestellungs)
        {
            String rechnungHeader = "Rechnung \nHildens bestes Restaurant \n" +
                    "40724 Hilden - Am Holterköpchen 34 \n" +
                    "Telefon: 02373 - 1234" +
                    "\n ************************************" +
                    " \n Rechnung NR.\n"
                     + RechnungsNummer +
                    "\n====================================";
            String rechnungKoerper = null;
            for (int i = 0; i < bestellungs.Count; ++i)
            {
                rechnungKoerper += "\n" + bestellungs[i].KartenElement.ElemName + "   " + bestellungs[i].KartenElement.Preis + "€ " +
                    "\n------------------------------------";
            }


            String rechnungsFuß = "\n====================================" +
                    "\nTolal " + rechnungsTotalBetrag + "€" +
                    "\nTrinkgeld: " + rechnungsTrinkgeldBetrag + "€" +
                    "\nBar: " + (rechnungsTotalBetrag + rechnungsTrinkgeldBetrag) + "€" +
                    "\nEs bediente Sie " + mitarbeiter.nachname +
                    "\n Vielen Dank";


            return rechnungHeader + rechnungKoerper + rechnungsFuß;

        }



    }
}
