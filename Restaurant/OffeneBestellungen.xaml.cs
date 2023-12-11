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
using System.Windows.Threading;

namespace Restaurant
{
    /// <summary>
    /// Interaktionslogik für OffeneBestellungen.xaml
    /// </summary>
    public partial class OffeneBestellungen : UserControl
    {

        Mitarbeiter eingelogterMitarbeiter;
        Tischauswahl vorherigesFenster;
        List<Bestellung> offeneBestellungen;
        Datenbankservice datenbankservice = new Datenbankservice();
        private DispatcherTimer timer;
        public OffeneBestellungen(Mitarbeiter eingelogterMitarbeiter, Tischauswahl vorherigesFenster)
        {
            InitializeComponent();
            this.eingelogterMitarbeiter = eingelogterMitarbeiter;
            this.vorherigesFenster = vorherigesFenster;
            if(eingelogterMitarbeiter.taetigkeitsbereich ==3 || eingelogterMitarbeiter.taetigkeitsbereich == 99)
            {
                reiterTabControl.SelectedIndex = 0;
            }else
            {
                reiterTabControl.SelectedIndex=1;
            }
            offeneBestellungen = datenbankservice.ermittelnAlleOffeneBestellungen();
            fuellleReiterGridView();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;

            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            offeneBestellungen = datenbankservice.ermittelnAlleOffeneBestellungen();
            fuellleReiterGridView();
        }
        private void fuellleReiterGridView()
        {
            if (offeneBestellungen != null)
            {
                if (reiterTabControl.SelectedIndex == 0)
                {
                    barDataGrid.ItemsSource = offeneBestellungen.FindAll(e => findeAllePassendenBestellungen(e, 0));
                }
                else
                {
                    kuecheDataGrid.ItemsSource = offeneBestellungen.FindAll(e => findeAllePassendenBestellungen(e, 1));
                }
            }else
            {
                barDataGrid.ItemsSource = null;
                kuecheDataGrid.ItemsSource = null;
            }
            

        }

        private void reiterGewechselt(object sender, SelectionChangedEventArgs e)
        {
            fuellleReiterGridView();
        }

        private static bool findeAllePassendenBestellungen(Bestellung bestellung,int tab)
        {
            if (bestellung != null)
            {
                if (tab == 0)
                {
                    return bestellung.KartenElement.ElementArtNr == 4;
                }
                else
                {
                    return bestellung.KartenElement.ElementArtNr != 4;
                }
            }
            return false;
        }

        private void zurueck_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.changeContent(vorherigesFenster);
        }

        private void barDataGridZeileGeaendert(object sender, DataGridCellEditEndingEventArgs e)
        {
           if(e.EditAction == DataGridEditAction.Commit)
            {
                int index = e.Row.GetIndex();
                Bestellung geaenderteBestellung = (Bestellung)barDataGrid.Items[index];
                geaenderteBestellung.Erledigt = !geaenderteBestellung.Erledigt;
                datenbankservice.SpeichernBestellung(geaenderteBestellung);
            }
        }

        private void kuecheDataGridGeaendert(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                int index = e.Row.GetIndex();
                Bestellung geaenderteBestellung = (Bestellung)kuecheDataGrid.Items[index];
                geaenderteBestellung.Erledigt = !geaenderteBestellung.Erledigt;
                datenbankservice.SpeichernBestellung(geaenderteBestellung);
            }
        }
    }
}
