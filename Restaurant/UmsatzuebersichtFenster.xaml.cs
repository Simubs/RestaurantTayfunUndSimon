using Restaurant.Entitys;
using Restaurant.Services;
using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für UmsatzuebersichtFenster.xaml
    /// </summary>
    public partial class UmsatzuebersichtFenster : UserControl
    {
        private UserControl vorherigesFenster;
        private Mitarbeiter eingelogterMitarbeiter;

        private double UmsatzDieserTag;
        private double UmsatzVortag;
        private double Prozent;

        Datenbankservice datenbankservice = new Datenbankservice();

        List<Mitarbeiter> mitarbeiterList = new List<Mitarbeiter>();

        private DateTime ausgewaehltesDatum = DateTime.Today;

        public UmsatzuebersichtFenster(UserControl vorherigesFenster,Mitarbeiter eingelogterMitarbeiter)
        {
            InitializeComponent();
            // Coloring using Constants
            this.Background = Constants.Constants.DEFAULT_BACKGROUND_COLOR;
            this.vorherigesFenster = vorherigesFenster;
            this.eingelogterMitarbeiter = eingelogterMitarbeiter;
            if (eingelogterMitarbeiter.taetigkeitsbereich != 99) { 
                TrinkgeldListView.Visibility = Visibility.Hidden; 
            }
            DatumPicker.DisplayDate = ausgewaehltesDatum;
            aktualisieren();
        }

        private void AktualisierenButton_Click(object sender, RoutedEventArgs e)
        {
            aktualisieren();
        }

        private void ZurueckButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.changeContent(vorherigesFenster);
        }

        private void aktualisieren()
        {
            berechnenTagesUmsatz();
            berechnenUmsatzVortag();
            berechneProzentualeVeraenderung();
            befuelleMitarbeiterTrinkgeld();

        }



        private void berechnenTagesUmsatz()
        {
            UmsatzDieserTag = datenbankservice.berechneUmsatzByTag(ausgewaehltesDatum);

            UmsatzTextBox.Text = Math.Round(UmsatzDieserTag, 2).ToString() + " €";

        }

        private void befuelleMitarbeiterTrinkgeld()
        {
            TrinkgeldListView.ItemsSource = null;
            mitarbeiterList = datenbankservice.ermittelnAlleMitarbeiterMitTrinkgeld(ausgewaehltesDatum);
            TrinkgeldListView.ItemsSource = mitarbeiterList;

        }

        private void berechnenUmsatzVortag()
        {
            UmsatzVortag = datenbankservice.berechneUmsatzByTag(ausgewaehltesDatum.AddDays(-1));

        }

        private void berechneProzentualeVeraenderung()
        {
            Prozent = ((UmsatzDieserTag - UmsatzVortag) / UmsatzVortag) * 100;
            ProzentualeVeraenderungTextBox.Text = Math.Round(Prozent,2).ToString() + " %";
            if(Prozent < 0)
            {
                ProzentualeVeraenderungTextBox.Foreground = Brushes.Red;
            } else
            {
                ProzentualeVeraenderungTextBox.Foreground = Brushes.Green;
            }

        }


        private void DatumGeaendert(object sender, SelectionChangedEventArgs e)
        {
            ausgewaehltesDatum = DatumPicker.SelectedDate.Value;
            aktualisieren();
        }
    }
}
