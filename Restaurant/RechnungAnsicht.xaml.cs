using Restaurant.Entitys;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restaurant
{
    /// <summary>
    /// Interaktionslogik für RechnungAnsicht.xaml
    /// </summary>
    public partial class RechnungAnsicht : UserControl
    {

        private List<Bestellung> offeneBestellungs = new List<Bestellung>();
        private List<Bestellung> rechnungBestellungs = new List<Bestellung>();
        private List<Bestellung> DatenbankBestellungen = new List<Bestellung>();

        BestellFenster vorgaengerFenster;
        Tisch ausgewaehlterTisch;
        Mitarbeiter eingelogterMitarbeiter;

        double trinkgeldBetrag = 0;

        double zuZahlenderBetrag = 0;

        double trinkgeldProzent = 0.15;

        private Datenbankservice datenbankservice = new Datenbankservice();

        public RechnungAnsicht(BestellFenster vorgaengerFenster,Tisch ausgewaehlterTisch,Mitarbeiter eingelogterMitarbeiter)
        {
            InitializeComponent();
            // Coloring using Constants
            this.Background = Constants.Constants.DEFAULT_BACKGROUND_COLOR;
            this.vorgaengerFenster = vorgaengerFenster;
            this.ausgewaehlterTisch = ausgewaehlterTisch;
            this.eingelogterMitarbeiter = eingelogterMitarbeiter;

            fuellenBestellungen();

        }

        public void fuellenBestellungen()
        {
            offeneBestellungs = datenbankservice.ermittelnBestellungen(ausgewaehlterTisch.tischNr);
            DatenbankBestellungen = offeneBestellungs;
            OffeneBestellungenDataGrid.ItemsSource = new List<Bestellung>();
            OffeneBestellungenDataGrid.ItemsSource = offeneBestellungs;
        }

        private void zurueckButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BezahlenButton_Click(object sender, RoutedEventArgs e)
        {

            Rechnung rechnung = RechnungErsteller.ErstelleRechnung(zuZahlenderBetrag, trinkgeldBetrag, eingelogterMitarbeiter.mitarbeiternummer);
            datenbankservice.erstelleRechnung(rechnung);
            if (rechnung != null)
            {
                for (int i = 0; i < rechnungBestellungs.Count; i++)
                {
                    rechnungBestellungs[i].RechnungNr = rechnung.RechnungNr;
                    datenbankservice.SpeichernBestellung(rechnungBestellungs[i]);
                    
                }
                AusgewaehlteBestellungenDataGrid.ItemsSource = null;
                RechnungErsteller.ausgabeRechnung(RechnungErsteller.RechnungDateiErsteller(rechnung.RechnungNr,rechnung.RechnungBetrag,rechnung.Trinkgeld,eingelogterMitarbeiter, rechnungBestellungs), rechnung.RechnungNr);
                rechnungBestellungs = new List<Bestellung>();
                zuZahlenderBetrag = 0;
                trinkgeldBetrag = 0;
            }
            else
            {
                throw new Exception("Es konnte Keine Rechnung erstellt werden!");
            }


        }

        private void fuenfzehnCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            trinkgeldProzent = 0.15;
            if (zwanzigCheckBox != null && zehnCheckBox1 != null && fuenfzehnCheckBox != null)
            {
                zehnCheckBox1.IsChecked = false;
                zwanzigCheckBox.IsChecked = false;
            }
            betragBerechnen(null, true);
        }

        private void zehnCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            trinkgeldProzent = 0.1;
            if (zwanzigCheckBox != null && zehnCheckBox1 != null && fuenfzehnCheckBox != null)
            {
                fuenfzehnCheckBox.IsChecked = false;
                zwanzigCheckBox.IsChecked = false;
            }
            betragBerechnen(null, true);
        }

        private void zwanzigCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            trinkgeldProzent = 0.2;
            if (zwanzigCheckBox != null && zehnCheckBox1 != null && fuenfzehnCheckBox != null)
            {
                fuenfzehnCheckBox.IsChecked = false;
                zehnCheckBox1.IsChecked = false;
            }
            betragBerechnen(null, true);
        }

        private void HinzufuegenButton_Click(object sender, RoutedEventArgs e)
        {
            Bestellung ausgewaehlteBestellung = OffeneBestellungenDataGrid.SelectedItem as Bestellung;
            rechnungBestellungs.Add(ausgewaehlteBestellung);
            offeneBestellungs.Remove(ausgewaehlteBestellung);
            OffeneBestellungenDataGrid.ItemsSource = null;
            OffeneBestellungenDataGrid.ItemsSource = offeneBestellungs;
            AusgewaehlteBestellungenDataGrid.ItemsSource = null;
            AusgewaehlteBestellungenDataGrid.ItemsSource = rechnungBestellungs;
            betragBerechnen(ausgewaehlteBestellung,true);

        }

        private void betragBerechnen(Bestellung ausgewaehlteBestellung, bool dazuRechnen)
        {
            if (ausgewaehlteBestellung != null)
            {
                if (dazuRechnen)
                {
                    zuZahlenderBetrag += ausgewaehlteBestellung.KartenElement.Preis;
                    trinkgeldBetrag = zuZahlenderBetrag * trinkgeldProzent;
                }
                else
                {
                    zuZahlenderBetrag -= ausgewaehlteBestellung.KartenElement.Preis;
                    trinkgeldBetrag = zuZahlenderBetrag * trinkgeldProzent;
                }
            } else
            {
                trinkgeldBetrag = zuZahlenderBetrag * trinkgeldProzent;
            }
            if (TrinkgeldLabel != null && BetragLabel != null)
            {
                TrinkgeldLabel.Content = Math.Round(trinkgeldBetrag,2).ToString() + " €";
                BetragLabel.Content = Math.Round((zuZahlenderBetrag + trinkgeldBetrag),2).ToString() + " €";
            }
        }

        private void loeschenButton_Click(object sender, RoutedEventArgs e)
        {
            Bestellung ausgewaehlteBestellung = AusgewaehlteBestellungenDataGrid.SelectedItem as Bestellung;
            rechnungBestellungs.Remove(ausgewaehlteBestellung);
            offeneBestellungs.Add(ausgewaehlteBestellung);
            OffeneBestellungenDataGrid.ItemsSource = null;
            OffeneBestellungenDataGrid.ItemsSource = offeneBestellungs;
            AusgewaehlteBestellungenDataGrid.ItemsSource = null;
            AusgewaehlteBestellungenDataGrid.ItemsSource = rechnungBestellungs;
            betragBerechnen(ausgewaehlteBestellung, false);
        }

        private void BezahlenDruckenButton_Click(object sender, RoutedEventArgs e)
        {
            Rechnung rechnung = RechnungErsteller.ErstelleRechnung(zuZahlenderBetrag, trinkgeldBetrag, eingelogterMitarbeiter.mitarbeiternummer);
            datenbankservice.erstelleRechnung(rechnung);
            if (rechnung != null)
            {
                for (int i = 0; i < rechnungBestellungs.Count; i++)
                {
                    rechnungBestellungs[i].RechnungNr = rechnung.RechnungNr;
                    datenbankservice.SpeichernBestellung(rechnungBestellungs[i]);

                }
                AusgewaehlteBestellungenDataGrid.ItemsSource = null;
                String ausgabe = RechnungErsteller.RechnungDateiErsteller(rechnung.RechnungNr, rechnung.RechnungBetrag, rechnung.Trinkgeld, eingelogterMitarbeiter, rechnungBestellungs);
                RechnungErsteller.ausgabeRechnung(ausgabe, rechnung.RechnungNr);
                PrintDoc(ausgabe,rechnung);
                
                rechnungBestellungs = new List<Bestellung>();
                zuZahlenderBetrag = 0;
                trinkgeldBetrag = 0;
            }
            else
            {
                throw new Exception("Es konnte Keine Rechnung erstellt werden!");
            }
            
        }
        private void PrintDoc(string doc, Rechnung rechnung)
        {
            Process printjob = new Process();
            printjob.StartInfo.FileName = Constants.Constants.RECHNUNG_DATEI_PFAD + rechnung.RechnungNr + ".html";
            printjob.StartInfo.UseShellExecute = true;
            printjob.StartInfo.Verb = "print";
            printjob.StartInfo.CreateNoWindow = true;
            printjob.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            printjob.Start();

        }

        private void FensterGeschlossen(object sender, EventArgs e)
        {
            vorgaengerFenster.Visibility = Visibility.Visible;
        }
    }
}
