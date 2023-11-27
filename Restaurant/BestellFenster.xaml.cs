using Restaurant.Entitys;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Interaktionslogik für BestellFenster.xaml
    /// </summary>
    public partial class BestellFenster : Window
    {

        private List<Bestellung> bestellungs = new List<Bestellung>();
        private List<Bestellung> DatenbankBestellungen = new List<Bestellung>();

        private List<KartenElement> kartenElements = new List<KartenElement>();

        private Datenbankservice datenbankservice = new Datenbankservice();
        public Tischauswahl vorherigesFenster;
        private Tisch ausgewaehlterTisch;
        Mitarbeiter eingelogterMitarbeiter;

        public BestellFenster(Tischauswahl vorherigesFenster,int ElementArt, Tisch ausgewaehlterTisch,Mitarbeiter eingelogterMitarbeiter)
        {
            this.vorherigesFenster = vorherigesFenster;
            this.ausgewaehlterTisch = ausgewaehlterTisch;
            this.eingelogterMitarbeiter = eingelogterMitarbeiter;
            
            InitializeComponent();
            // Coloring using Constants
            this.Background = Constants.Constants.DEFAULT_BACKGROUND_COLOR;
            ermittelnDerKartenelemente(ElementArt);
            fuellenBestellungen();
            befuellenEingrenzenComboBox();
        }

        public void fuellenBestellungen()
        {
            bestellungs = datenbankservice.ermittelnBestellungen(ausgewaehlterTisch.tischNr);
            DatenbankBestellungen = bestellungs;
            BestellungenDataGrid.ItemsSource = new List<Bestellung>();
            BestellungenDataGrid.ItemsSource = bestellungs;
        }

        private void befuellenEingrenzenComboBox()
        {
            ElementArtAuswahlComboBox.Items.Add("Alle Elemente");
            ElementArtAuswahlComboBox.Items.Add("Vorspeise");
            ElementArtAuswahlComboBox.Items.Add("Hauptspeise");
            ElementArtAuswahlComboBox.Items.Add("Nachtisch");
            ElementArtAuswahlComboBox.Items.Add("Getränke");
        }

        private void ermittelnDerKartenelemente(int elementArt)
        {

            kartenElements = datenbankservice.ermittelnKartenElementsByElementArt(elementArt);
            
            KartenElementeGridView.ItemsSource = kartenElements;
            
        }

        private void HinzufuegenButton_Click(object sender, RoutedEventArgs e)
        {
            KartenElement ausgewaehltesElement = KartenElementeGridView.SelectedItem as KartenElement;
            bestellungs.Add(new Bestellung(0, "0", ausgewaehlterTisch.tischNr,ausgewaehltesElement, ausgewaehltesElement.KartenElementNr,hinweiseTextBox.Text,DateTime.Now,false,0));
            BestellungenDataGrid.ItemsSource = null;
            BestellungenDataGrid.ItemsSource = bestellungs;
        }

        private void loeschenButton_Click(object sender, RoutedEventArgs e)
        {
            Bestellung ausgewaehltesElement = BestellungenDataGrid.SelectedItem as Bestellung;

            if (ausgewaehltesElement.BestellNr != 0)
            {
                datenbankservice.loeschenBestellung(ausgewaehltesElement.BestellNr);
            }

            KartenElementeGridView.SelectedItem = null;
            
            bestellungs.Remove(ausgewaehltesElement);

            BestellungenDataGrid.ItemsSource=null;
            BestellungenDataGrid.ItemsSource = bestellungs;
            
        }

        private void zurueck_Click(object sender, RoutedEventArgs e)
        {
           
            Close();
        }


        private async void BestellungAbschicken_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0;i<bestellungs.Count;i++)
            {
                datenbankservice.SpeichernBestellung(bestellungs[i]);
            }

           await Task.Delay(1000);

            fuellenBestellungen();
            
            

        }

        public void aktualisieren()
        {
            bestellungs = new List<Bestellung>();
        }

        private async void TischWechselnButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < bestellungs.Count; i++)
            {
                datenbankservice.SpeichernBestellung(bestellungs[i]);
            }
            await Task.Delay(1000);
            TischUebergabeFenster tischUebergabeFenster = new TischUebergabeFenster(this,ausgewaehlterTisch);
            tischUebergabeFenster.Show();
            fuellenBestellungen();
        }

        private void KartenElementArtGeändert(object sender, SelectionChangedEventArgs e)
        {
            int ausgewaehlteEingrenzung = ElementArtAuswahlComboBox.SelectedIndex;


            ermittelnDerKartenelemente(ausgewaehlteEingrenzung);
        }

        private void AbrechnenButton_Click(object sender, RoutedEventArgs e)
        {
            RechnungAnsicht rechnungAnsicht = new RechnungAnsicht(this,ausgewaehlterTisch,eingelogterMitarbeiter);
            Visibility = Visibility.Hidden;
            rechnungAnsicht.Show();

        }

        private void FensterGeschlossen(object sender, EventArgs e)
        {
            vorherigesFenster.Visibility = Visibility.Visible;
        }
    }
}
