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
    /// Interaktionslogik für Startseite.xaml
    /// </summary>
    public partial class Startseite : Window
    {
        public Startseite()
        {
            InitializeComponent();
        }

        private void clickVorspeiseButton(object sender, RoutedEventArgs e)
        {

        }

        private void clickHauptspeiseButton(object sender, RoutedEventArgs e)
        {

        }

        private void clickNachtischButton(object sender, RoutedEventArgs e)
        {

        }

        private void clickGetraenkeButton(object sender, RoutedEventArgs e)
        {

        }

        private void clickMitarbeiteransichtButton(object sender, RoutedEventArgs e)
        {
            LogInMitarbeiter logInFenster = new LogInMitarbeiter(this);
            Visibility = Visibility.Hidden;
            logInFenster.Show();

        }

        //private void RechnungAnsichtButton_Click(object sender, RoutedEventArgs e)
        //{
        //    RechnungAnsicht rechnungAnsicht = new RechnungAnsicht(this);
        //    Visibility = Visibility.Hidden;
        //    rechnungAnsicht.Show();
        //}
    }
}
