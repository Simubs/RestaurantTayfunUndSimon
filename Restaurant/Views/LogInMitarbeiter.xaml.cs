using Restaurant.Entitys;
using System;
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
    /// Interaktionslogik für LogInMitarbeiter.xaml
    /// </summary>
    public partial class LogInMitarbeiter : Window
    {
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Entwicklung\\ScheisVSProjekte\\Restaurant\\Restaurant\\Datenbank\\Restaurant-Datenbank.accdb";
        OleDbConnection dataConnection;
        Startseite vorgaengerFenster;
        public LogInMitarbeiter(Startseite vorgaengerFenster)
        {
            InitializeComponent();
            dataConnection = new OleDbConnection(connectionString);
            this.vorgaengerFenster = vorgaengerFenster;
        }

        private void clickLogInButton(object sender, RoutedEventArgs e)
        {
            String mitarbeiternummer = TextboxMitarbeiternummer.Text;

            String passwort = PasswortBox.Password;

            Mitarbeiter gefundenerMitarbeiter = findeMitarbeiter(mitarbeiternummer,passwort);


            if(gefundenerMitarbeiter != null)
            {
                Tischauswahl tischauswahl = new Tischauswahl(this, gefundenerMitarbeiter);
                Visibility = Visibility.Hidden;
                tischauswahl.ShowDialog();
            } else
            {
                //TODO fehlermeldung schreiben
            }
        }

        private Mitarbeiter findeMitarbeiter(String mitarbeiternummer, String passwort)
        {
            Mitarbeiter gefundenerMitarbeiter = null;
            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT COUNT(*) FROM PERSONALLOGIN WHERE MITARBEITERNR = '" + mitarbeiternummer + "' AND PASSWORT = '" + passwort + "';";

                OleDbDataReader reader = command.ExecuteReader();

                reader.Read();
                if(reader.GetInt32(0) == 0)
                {
                    return null;
                }
                reader.Close();

                command.CommandText = "SELECT PERSONAL_NR,VORNAME,NACHNAME,TAETIGKEITSBEREICH FROM PERSONAL WHERE PERSONAL_NR = " + mitarbeiternummer + ";";

                OleDbDataReader readerPersonal = command.ExecuteReader();

                while (readerPersonal.Read())
                {
                    gefundenerMitarbeiter = new Mitarbeiter(readerPersonal.GetInt32(0), readerPersonal.GetString(1),readerPersonal.GetString(2),readerPersonal.GetInt32(3));
                }

                readerPersonal.Close();
                dataConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            


            return gefundenerMitarbeiter;
        }

        private void clickZurueckButton(object sender, RoutedEventArgs e)
        {
            vorgaengerFenster.Visibility = Visibility.Visible;
            Close();
        }
    }
}
