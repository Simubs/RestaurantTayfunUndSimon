using Restaurant.Entitys;
using Restaurant.Services;
using System;
using System.Collections;
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
    /// Interaktionslogik für TischUebergabeFenster.xaml
    /// </summary>
    public partial class TischUebergabeFenster : Window
    {

        private BestellFenster vorgaengerFenster;
        private Mitarbeiter eingelogterMitarbeiter;
        private Tisch ausgewaelterTisch;
        private Tisch vorherigerTisch;
        private int gewuensteSitzplaetze = 0;
        private Hashtable tische = new Hashtable();
        private Datenbankservice datenbankservice = new Datenbankservice();

        public TischUebergabeFenster(BestellFenster vorgaengerFenster,Tisch vorherigerTisch)
        {
            this.vorherigerTisch = vorherigerTisch;
            this.vorgaengerFenster = vorgaengerFenster;
            tische = datenbankservice.bekommeAlleTische();
            InitializeComponent();
            
        }

        private void tischeAuswaehlen()
        {
            Tisch1.IsEnabled = isTischGeeignet((Tisch)tische[1]);
            Tisch2.IsEnabled = isTischGeeignet((Tisch)tische[2]);
            Tisch3.IsEnabled = isTischGeeignet((Tisch)tische[3]);    
            Tisch4.IsEnabled = isTischGeeignet((Tisch)tische[4]);
            Tisch5.IsEnabled = isTischGeeignet((Tisch)tische[5]);
            Tisch6.IsEnabled = isTischGeeignet((Tisch)tische[6]);
            Tisch7.IsEnabled = isTischGeeignet((Tisch)tische[7]);
            Tisch8.IsEnabled = isTischGeeignet((Tisch)tische[8]);
            Tisch9.IsEnabled = isTischGeeignet((Tisch)tische[9]);
            Tisch10.IsEnabled = isTischGeeignet((Tisch)tische[10]);
            Tisch11.IsEnabled = isTischGeeignet((Tisch)tische[11]);
            Tisch12.IsEnabled = isTischGeeignet((Tisch)tische[12]);
            Tisch13.IsEnabled = isTischGeeignet((Tisch)tische[13]);
            Tisch14.IsEnabled = isTischGeeignet((Tisch)tische[14]);
            Tisch15.IsEnabled = isTischGeeignet((Tisch)tische[15]);
            Tisch16.IsEnabled = isTischGeeignet((Tisch)tische[16]);
            Tisch17.IsEnabled = isTischGeeignet((Tisch)tische[17]);
            Tisch18.IsEnabled = isTischGeeignet((Tisch)tische[18]);
            Tisch19.IsEnabled = isTischGeeignet((Tisch)tische[19]);
            Tisch20.IsEnabled = isTischGeeignet((Tisch)tische[20]);
            Tisch21.IsEnabled = isTischGeeignet((Tisch)tische[21]);
            Tisch22.IsEnabled = isTischGeeignet((Tisch)tische[22]);
            Tisch23.IsEnabled = isTischGeeignet((Tisch)tische[23]);
            Tisch24.IsEnabled = isTischGeeignet((Tisch)tische[24]);
            Tisch25.IsEnabled = isTischGeeignet((Tisch)tische[25]);
        }

        private bool isTischGeeignet(Tisch tisch)
        {
            return tisch.tischNr != vorherigerTisch.tischNr && tisch.sitzplaetze >= gewuensteSitzplaetze;
        }

        private void zurueckButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Tisch1_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[1];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            
        }

        private void Tisch2_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[2];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            
        }

        private void Tisch3_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[3];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            
        }

        private void Tisch4_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[4];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            
        }

        private void Tisch5_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[5];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
           
        }

        private void Tisch6_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[6];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
           
        }

        private void Tisch7_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[7];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
          
        }

        private void Tisch8_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[8];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
          
        }

        private void Tisch9_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[9];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
      
        }

        private void Tisch10_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[10];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
    
        }

        private void Tisch11_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[11];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
     
        }

        private void Tisch12_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[12];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
        
        }

        private void Tisch13_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[13];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
       
        }

        private void Tisch14_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[14];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
    

        }

        private void Tisch15_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[15];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();

        }

        private void Tisch16_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[16];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
           
        }

        private void Tisch17_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[17];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
           
        }

        private void Tisch18_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[18];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
   
        }

        private void Tisch19_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[19];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
         
        }

        private void Tisch20_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[20];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
   
        }

        private void Tisch21_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[21];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
           
        }

        private void Tisch22_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[22];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();

        }

        private void Tisch23_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[23];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            
        }

        private void Tisch24_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[24];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
     
        }

        private void Tisch25_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[25];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            
        }

        private void ValueGeaendertSlider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            gewuensteSitzplaetze = (int) e.NewValue;
            if (SitzplaetzeAnzahlTextFeld != null)
            {
                SitzplaetzeAnzahlTextFeld.Text = gewuensteSitzplaetze.ToString() == null ? "0" : gewuensteSitzplaetze.ToString();
            }
            tischeAuswaehlen();
        }

        private void aenderungTischAuswahl(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TischauswahlButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
