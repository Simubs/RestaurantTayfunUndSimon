﻿using Restaurant.Entitys;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class LogInMitarbeiter : UserControl
    {
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + RunConfigurationVariables.PATH_TO_DATABASE_DYNAMIC;
        OleDbConnection dataConnection;
        Startseite vorgaengerFenster;
        public LogInMitarbeiter(Startseite vorgaengerFenster)
        {
            InitializeComponent();
            // Coloring using Constants
            this.Background = Constants.Constants.DEFAULT_BACKGROUND_COLOR;
            dataConnection = new OleDbConnection(connectionString);
            this.vorgaengerFenster = vorgaengerFenster;
            if(RunConfigurationVariables.RUNNING_ON_DEBUG_MODE)
            {
                Button ByPassLoginButton = new Button();
                ByPassLoginButton.Content = "Bypass Login DebugFeature";
                ByPassLoginButton.Click += ByPassButtonClicked;
                ByPassLoginButton.HorizontalAlignment = HorizontalAlignment.Right;
                ByPassLoginButton.VerticalAlignment = VerticalAlignment.Bottom;
                ByPassLoginButton.Height = 50;
                MainGrid.Children.Add(ByPassLoginButton);


            }
        }

        private void ByPassButtonClicked(object sender, RoutedEventArgs e)
        {
            Mitarbeiter gefundenerMitarbeiter = findeMitarbeiter("3", "test");
            goToTischAuswahl(gefundenerMitarbeiter);
        }

        private void goToTischAuswahl(Mitarbeiter gefundenerMitarbeiter)
        {
            //Tischauswahl tischauswahl = new Tischauswahl(this, gefundenerMitarbeiter);
            //Visibility = Visibility.Hidden;
            //tischauswahl.ShowDialog();

            var mainWindow = MainWindow.Instance;
            Tischauswahl tischauswahl = new Tischauswahl(this, gefundenerMitarbeiter);
            mainWindow.changeContent(tischauswahl);

            
        }

        private void clickLogInButton(object sender, RoutedEventArgs e)
        {
            string mitarbeiternummer = TextboxMitarbeiternummer.Text;

            string passwort = PasswortBox.Password;

            Mitarbeiter gefundenerMitarbeiter = findeMitarbeiter(mitarbeiternummer,passwort);


            if(gefundenerMitarbeiter != null)
            {
                goToTischAuswahl(gefundenerMitarbeiter);
            } else
            {
                MessageBox.Show(Constants.Constants.FALSCHE_EINGABEN_FEHLERMELDUNG);
            }
        }

        private Mitarbeiter findeMitarbeiter(string mitarbeiternummer, string passwort)
        {
            Mitarbeiter gefundenerMitarbeiter = null;
            try
            {
                dataConnection.Open();
                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                
                Regex sqlInjectionRegex = new Regex("@[-<>=&%]");

                if (!sqlInjectionRegex.IsMatch(mitarbeiternummer) || sqlInjectionRegex.IsMatch(passwort))
                {
                    command.CommandText = "SELECT COUNT(*) FROM PERSONALLOGIN WHERE MITARBEITERNR = '" + mitarbeiternummer + "' AND PASSWORT = '" + passwort + "';";

                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if(reader.GetInt32(0) == 0)
                    {
                        dataConnection.Close();
                        return null;
                    }
                    reader.Close();

                } else
                {
                    dataConnection.Close();
                    throw new Exception("SQL Zeichenketten verwendet!");
                }

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
            
                MainWindow.Instance.changeContent(vorgaengerFenster);
            
        }

        private void FensterGeschlossen(object sender, EventArgs e)
        {
            var mainWindow = MainWindow.Instance;
            if (mainWindow != null)
            {
                mainWindow.changeContent(vorgaengerFenster);
            }
        }
    }
}
