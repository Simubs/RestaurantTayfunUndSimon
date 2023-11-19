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

        private List<KartenElement> kartenElements = new List<KartenElement>();
        private Datenbankservice datenbankservice = new Datenbankservice();
        private Tischauswahl vorherigesFenster;
        private Tisch ausgewaehlterTisch;

        public BestellFenster(Tischauswahl vorherigesFenster,int ElementArt, Tisch ausgewaehlterTisch)
        {
            this.vorherigesFenster = vorherigesFenster;
            this.ausgewaehlterTisch = ausgewaehlterTisch;
            Console.Write("Test");
            InitializeComponent();
            ermittelnDerKartenelemente(ElementArt);
        }

        private void ermittelnDerKartenelemente(int elementArt)
        {

            kartenElements = datenbankservice.ermittelnKartenElements(elementArt);
            for (int i = 0; i < kartenElements.Count; ++i)
            {
                KartenElementeGridView.Items.Add(new Object[] { kartenElements[i].ElemName, kartenElements[i].Preis });
            }
        }

        private void ArtSelected(object sender, RoutedEventArgs e)
        {

        }

        private void HinzufuegenButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void loeschenButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zurueck_Click(object sender, RoutedEventArgs e)
        {
            vorherigesFenster.Visibility = Visibility.Visible;
            Close();
        }
    }
}
