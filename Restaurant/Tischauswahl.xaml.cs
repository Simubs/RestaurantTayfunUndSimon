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
    public partial class Tischauswahl : Window
    {
        private LogInMitarbeiter vorgaengerFenster;
        private Mitarbeiter eingelogterMitarbeiter;
        private Tisch ausgewaelterTisch;
        private Hashtable tische = new Hashtable();
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Entwicklung\\ScheisVSProjekte\\Restaurant\\Restaurant\\Datenbank\\Restaurant-Datenbank.accdb";
        OleDbConnection dataConnection;


        public Tischauswahl(LogInMitarbeiter vorgaengerFenster, Mitarbeiter eingelogterMitarbeiter)
        {
            InitializeComponent();
            dataConnection = new OleDbConnection(connectionString);

            this.vorgaengerFenster = vorgaengerFenster;
            this.eingelogterMitarbeiter = eingelogterMitarbeiter;
            abfrageTische();
            tischeAuswaehlen();
        }

        private void tischeAuswaehlen()
        {

            Tisch1.IsEnabled = ((Tisch)tische[1]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch2.IsEnabled = ((Tisch)tische[2]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch3.IsEnabled = ((Tisch)tische[3]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch4.IsEnabled = ((Tisch)tische[4]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch5.IsEnabled = ((Tisch)tische[5]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch6.IsEnabled = ((Tisch)tische[6]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch7.IsEnabled = ((Tisch)tische[7]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch8.IsEnabled = ((Tisch)tische[8]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch9.IsEnabled = ((Tisch)tische[9]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch10.IsEnabled = ((Tisch)tische[10]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch11.IsEnabled = ((Tisch)tische[11]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch12.IsEnabled = ((Tisch)tische[12]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch13.IsEnabled = ((Tisch)tische[13]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch14.IsEnabled = ((Tisch)tische[14]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch15.IsEnabled = ((Tisch)tische[15]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch16.IsEnabled = ((Tisch)tische[16]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch17.IsEnabled = ((Tisch)tische[17]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch18.IsEnabled = ((Tisch)tische[18]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch19.IsEnabled = ((Tisch)tische[19]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch20.IsEnabled = ((Tisch)tische[20]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch21.IsEnabled = ((Tisch)tische[21]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch22.IsEnabled = ((Tisch)tische[22]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch23.IsEnabled = ((Tisch)tische[23]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch24.IsEnabled = ((Tisch)tische[24]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;
            Tisch25.IsEnabled = ((Tisch)tische[25]).mitarbeiternummer == eingelogterMitarbeiter.mitarbeiternummer;

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
                    Console.WriteLine(reader.GetInt32(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetInt32(2));
                    tische.Add(reader.GetInt32(0), new Tisch(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

                }
                reader.Close();
            
            }catch(Exception e) {
                Console.WriteLine("Fehler Datenbank :( " + e.Message);
            }



        }

        private void clickLogOutButton(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            vorgaengerFenster.Visibility = Visibility.Visible;
            Close();
        }

        private void Tisch1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Tisch2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch18_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch19_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch21_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch22_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch24_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tisch25_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TischauswahlButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void aenderungTischAuswahl(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
