using Restaurant.Entitys;
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
    /// Interaktionslogik für LogInMitarbeiter.xaml
    /// </summary>
    public partial class LogInMitarbeiter : Window
    {
        Startseite vorgaengerFenster;
        public LogInMitarbeiter(Startseite vorgaengerFenster)
        {
            InitializeComponent();
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



            return new Mitarbeiter(1,"Simon","Grewe",1);
        }

        private void clickZurueckButton(object sender, RoutedEventArgs e)
        {
            vorgaengerFenster.Visibility = Visibility.Visible;
            Close();
        }
    }
}
