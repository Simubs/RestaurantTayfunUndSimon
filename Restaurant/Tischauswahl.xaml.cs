using Restaurant.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
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
    /// Interaktionslogik für Tischauswahl.xaml
    /// </summary>
    public partial class Tischauswahl : UserControl
    {
        private LogInMitarbeiter vorgaengerFenster;
        private Mitarbeiter eingelogterMitarbeiter;
        private Tisch ausgewaelterTisch;
        private Hashtable tische = new Hashtable();
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + RunConfigurationVariables.PATH_TO_DATABASE_DYNAMIC;
        OleDbConnection dataConnection;


        public Tischauswahl(LogInMitarbeiter vorgaengerFenster, Mitarbeiter eingelogterMitarbeiter)
        {
            InitializeComponent();
            // Coloring using Constants
            this.Background = Constants.Constants.DEFAULT_BACKGROUND_COLOR;
            dataConnection = new OleDbConnection(connectionString);
            this.vorgaengerFenster = vorgaengerFenster;
            this.eingelogterMitarbeiter = eingelogterMitarbeiter;
            abfrageTische();
            tischeAuswaehlen();
            dropdownBefuellen();
            if(eingelogterMitarbeiter.taetigkeitsbereich == 1)
            {
                OffeneBestellungenButton.Visibility = Visibility.Hidden;
            }
        }

        private void dropdownBefuellen()
        {
            for (int i = 1; i <= tische.Count; ++i)
            {
                if (((Tisch)tische[i]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich==99)
                {
                    Tischauswahl1.Items.Add(i);
                }
            }
            }
              
        

        private void tischeAuswaehlen()
        {
            Tisch1.IsEnabled = ((Tisch)tische[1]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch2.IsEnabled = ((Tisch)tische[2]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch3.IsEnabled = ((Tisch)tische[3]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch4.IsEnabled = ((Tisch)tische[4]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch5.IsEnabled = ((Tisch)tische[5]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch6.IsEnabled = ((Tisch)tische[6]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch7.IsEnabled = ((Tisch)tische[7]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch8.IsEnabled = ((Tisch)tische[8]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch9.IsEnabled = ((Tisch)tische[9]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch10.IsEnabled = ((Tisch)tische[10]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch11.IsEnabled = ((Tisch)tische[11]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch12.IsEnabled = ((Tisch)tische[12]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch13.IsEnabled = ((Tisch)tische[13]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch14.IsEnabled = ((Tisch)tische[14]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch15.IsEnabled = ((Tisch)tische[15]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch16.IsEnabled = ((Tisch)tische[16]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch17.IsEnabled = ((Tisch)tische[17]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch18.IsEnabled = ((Tisch)tische[18]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch19.IsEnabled = ((Tisch)tische[19]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch20.IsEnabled = ((Tisch)tische[20]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch21.IsEnabled = ((Tisch)tische[21]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch22.IsEnabled = ((Tisch)tische[22]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch23.IsEnabled = ((Tisch)tische[23]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch24.IsEnabled = ((Tisch)tische[24]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
            Tisch25.IsEnabled = ((Tisch)tische[25]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer || eingelogterMitarbeiter.taetigkeitsbereich == 99;
        }

        private void abfrageTische()
        {
            try {  
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT TISCH_NR,PERSONAL_NR,SITZPLAETZE FROM TISCHE;";
                
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    tische.Add(reader.GetInt32(0), new Tisch(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

                }
                reader.Close();
            
            }catch(Exception e) {
                Console.WriteLine("Fehler Datenbank :( " + e.Message);
            }



        }

        private void clickLogOutButton(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.changeContent(vorgaengerFenster);
        }

        private void Tisch1_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[1];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "1";
        }

        private void Tisch2_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[2];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "2";
        }

        private void Tisch3_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[3];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "3";
        }

        private void Tisch4_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[4];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "4";
        }

        private void Tisch5_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[5];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "5";
        }

        private void Tisch6_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[6];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "6";
        }

        private void Tisch7_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[7];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "7";
        }

        private void Tisch8_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[8];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "8";
        }

        private void Tisch9_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[9];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "9";
        }

        private void Tisch10_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[10];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "10";
        }

        private void Tisch11_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[11];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "11";
        }

        private void Tisch12_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[12];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "12";
        }

        private void Tisch13_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[13];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "13";
        }

        private void Tisch14_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[14];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "14";

        }

        private void Tisch15_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[15];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "15";
        }

        private void Tisch16_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[16];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "16";
        }

        private void Tisch17_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[17];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "17";
        }

        private void Tisch18_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[18];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "18";
        }

        private void Tisch19_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[19];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "19";
        }

        private void Tisch20_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[20];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "20";
        }

        private void Tisch21_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[21];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "21";
        }

        private void Tisch22_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[22];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "22";
        }

        private void Tisch23_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[23];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "23";
        }

        private void Tisch24_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[24];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "24";
        }

        private void Tisch25_Click(object sender, RoutedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[25];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
            Tischauswahl1.SelectedItem = "25";
        }

        private void TischauswahlButton_Click(object sender, RoutedEventArgs e)
        {
            //BestellFenster bestellFenster = new BestellFenster(this, 1, ausgewaelterTisch,eingelogterMitarbeiter);
            //bestellFenster.Show();
            //this.Visibility = Visibility.Hidden;
            BestellFenster bestellFenster = new BestellFenster(this, 1, ausgewaelterTisch, eingelogterMitarbeiter);
            MainWindow.Instance.changeContent(bestellFenster);
        }

    

        private void aenderungTischAuswahl(object sender, SelectionChangedEventArgs e)
        {
            ausgewaelterTisch = (Tisch)tische[Tischauswahl1.SelectedItem];
            AnzahlSitzplaetzeBox.Text = ausgewaelterTisch.sitzplaetze.ToString();
        }

        private void UmsatzuebersichtButton_Click(object sender, RoutedEventArgs e)
        {
            //UmsatzuebersichtFenster umsatzuebersichtFenster = new UmsatzuebersichtFenster(this,eingelogterMitarbeiter);
            //umsatzuebersichtFenster.Show();
            var mainWindow = MainWindow.Instance;
            UmsatzuebersichtFenster umsatzuebersichtFenster = new UmsatzuebersichtFenster(this, eingelogterMitarbeiter);
            mainWindow.changeContent(umsatzuebersichtFenster);


        }

        private void FensterGeschlossen(object sender, EventArgs e)
        {
            vorgaengerFenster.Visibility = Visibility.Visible;
        }

        private void clickOffeneBestellungenButton(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.changeContent(new OffeneBestellungen(eingelogterMitarbeiter, this));
        }
    }
}
