using Restaurant.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    public class Datenbankservice
    {
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + RunConfigurationVariables.PATH_TO_DATABASE_DYNAMIC;
        OleDbConnection dataConnection;
        public List<KartenElement> ermittelnKartenElementsByElementArt(int elementArt)
        {
           
            dataConnection = new OleDbConnection(connectionString);

            List<KartenElement> kartenelemente = new List<KartenElement>();

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT K_ELEM_NR,ELEM_NAME,PREIS,ELEM_ART_NR FROM KARTEN_ELEMENTE WHERE "+elementArt+" = 0 OR ELEM_ART_NR = "+elementArt+";";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    kartenelemente.Add(new KartenElement(reader.GetInt32(0),reader.GetString(1),reader.GetInt32(2),reader.GetInt32(3)));

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( ermittelnKartenElementsByElementArt " + e.Message);
            }

            return kartenelemente;
        }

        public KartenElement ermittelnKartenElementsByElementNr(int elementNr)
        {

            dataConnection = new OleDbConnection(connectionString);

            KartenElement kartenelement = null;

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT K_ELEM_NR,ELEM_NAME,PREIS,ELEM_ART_NR FROM KARTEN_ELEMENTE WHERE K_ELEM_NR = " + elementNr + ";";

                OleDbDataReader reader = command.ExecuteReader();

                reader.Read();

                kartenelement= new KartenElement(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));

                
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( ermittelnKartenElementsByElementNr " + e.Message);
            }

            return kartenelement;
        }

        public List<Bestellung> ermittelnBestellungen(int TischNr)
        {
            dataConnection = new OleDbConnection(connectionString);

            List<Bestellung> bestellungen = new List<Bestellung>();

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT BESTELL_NR,RECHNUNGS_NR,K_ELEM_NR,GAESTE_NR,BESONDERHEITEN,AUFGEGEBEN_AM,BESTELLUNG_ERLEDIGT,TISCH_NR FROM BESTELLUNGEN WHERE AUFGEGEBEN_AM = '"+DateTime.Now.ToLongDateString()+"' AND TISCH_NR ="+TischNr+" AND RECHNUNGS_NR = '0' ;";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    bestellungen.Add(new Bestellung(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(7),ermittelnKartenElementsByElementNr(reader.GetInt32(2)), reader.GetInt32(2),reader.GetString(4),DateTime.Parse(reader.GetString(5)),reader.GetBoolean(6),reader.GetInt32(3)));

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( ermittelnBestellungen " + e.Message);
            }

            return bestellungen;


        }

     public void SpeichernBestellung(Bestellung zuSpeicherndeBestellung)
        {
            dataConnection = new OleDbConnection(connectionString);

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                if (zuSpeicherndeBestellung.BestellNr == 0) {
                    command.CommandText = "INSERT INTO Bestellungen(RECHNUNGS_NR,K_ELEM_NR,GAESTE_NR,BESONDERHEITEN,AUFGEGEBEN_AM,BESTELLUNG_ERLEDIGT,TISCH_NR) VALUES (?,?,?,?,?,?,?);";
                    command.Parameters.AddWithValue("RECHNUNGS_NR", zuSpeicherndeBestellung.RechnungNr);
                    command.Parameters.AddWithValue("K_ELEM_NR", zuSpeicherndeBestellung.KartenElementNr);
                    command.Parameters.AddWithValue("GAESTE_NR", zuSpeicherndeBestellung.GaesteNr);
                    command.Parameters.AddWithValue("BESONDERHEITEN", zuSpeicherndeBestellung.Hinweise);
                    command.Parameters.AddWithValue("AUFGEGEBEN_AM", zuSpeicherndeBestellung.AufgegebenAm.ToLongDateString());
                    command.Parameters.AddWithValue("BESTELLUNG_ERLEDIGT", zuSpeicherndeBestellung.Erledigt);
                    command.Parameters.AddWithValue("TISCH_NR", zuSpeicherndeBestellung.TischNr);
                } else
                {
                    
                    command.CommandText = "UPDATE BESTELLUNGEN SET BESTELLUNG_ERLEDIGT = " + zuSpeicherndeBestellung.Erledigt + ", BESONDERHEITEN = '"+zuSpeicherndeBestellung.Hinweise+"', RECHNUNGS_NR = '"+zuSpeicherndeBestellung.RechnungNr+"' WHERE BESTELL_NR=" + zuSpeicherndeBestellung.BestellNr + ";";
                    
                }
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( SpeichernBestellung " + e.Message);
            }
        }

        internal void loeschenBestellung(int bestellNr)
        {
            dataConnection = new OleDbConnection(connectionString);

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "DELETE FROM BESTELLUNGEN WHERE BESTELL_NR ="+bestellNr+";";
                

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( loeschenBestellung " + e.Message);
            }
        }

        public Hashtable ermittelnBesetztentische()
        {
            Hashtable tisches = new Hashtable();

            dataConnection = new OleDbConnection(connectionString);
            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = $"SELECT TISCHE.TISCH_NR,TISCHE.PERSONAL_NR,TISCHE.SITZPLAETZE FROM TISCHE INNER JOIN BESTELLUNGEN  ON TISCHE.TISCH_NR = BESTELLUNGEN.TISCH_NR WHERE BESTELLUNGEN.RECHNUNGS_NR = 0 ";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    tisches.Add(reader.GetInt32(0), new Tisch(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( ermittelnBesetztentische "  + e.Message);
            }


            return tisches;
        }

        public Hashtable bekommeAlleTische()
        {
            Hashtable tisches = new Hashtable();
            dataConnection = new OleDbConnection(connectionString);
            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT TISCH_NR,PERSONAL_NR,SITZPLAETZE FROM TISCHE;";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    tisches.Add(reader.GetInt32(0), new Tisch(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( bekommeAlleTische " + e.Message);
            }


            return tisches;
        }

        public bool uebergebeTisch(Tisch vorherigerTisch, Tisch neuerTisch)
        {

            dataConnection = new OleDbConnection(connectionString);

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                

                command.CommandText = "UPDATE BESTELLUNGEN SET TISCH_NR = " + neuerTisch.tischNr + " WHERE TISCH_NR=" + vorherigerTisch.tischNr + ";";

                
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( uebergebeTisch " + e.Message);
                return false;
            }
            return true;
        }

        internal void erstelleRechnung(Rechnung zuSpeicherndeRechnung)
        {
            dataConnection = new OleDbConnection(connectionString);

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                
                command.CommandText = "INSERT INTO RECHNUNGEN(RECHNUNGS_NR,BETRAG,TRINKGELD,PERSONAL_NR,DATUM) VALUES (?,?,?,?,?);";
                command.Parameters.AddWithValue("RECHNUNGS_NR", zuSpeicherndeRechnung.RechnungNr);
                command.Parameters.AddWithValue("BETRAG", zuSpeicherndeRechnung.RechnungBetrag);
                command.Parameters.AddWithValue("TRINKGELD", zuSpeicherndeRechnung.Trinkgeld);
                command.Parameters.AddWithValue("PERSONAL_NR", zuSpeicherndeRechnung.PersonalNr);
                command.Parameters.AddWithValue("DATUM", zuSpeicherndeRechnung.Datum);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( erstelleRechnung " + e.Message);
            }
        }
    }
}
