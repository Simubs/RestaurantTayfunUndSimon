using Restaurant.Entitys;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    public class Datenbankservice
    {
    public List<KartenElement> ermittelnKartenElements(int elementArt)
        {
            String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + RunConfigurationVariables.PATH_TO_DATABASE_DYNAMIC;
            OleDbConnection dataConnection;
            dataConnection = new OleDbConnection(connectionString);

            List<KartenElement> kartenelemente = new List<KartenElement>();

            try
            {
                dataConnection.Open();

                OleDbCommand command = dataConnection.CreateCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM KARTEN_ELEMENTE WHERE ELEM_ART_NR = "+elementArt+";";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    kartenelemente.Add(new KartenElement(reader.GetInt32(0),reader.GetString(1),reader.GetDouble(2),reader.GetInt32(3)));

                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler Datenbank :( " + e.Message);
            }

            return kartenelemente;
        }


    }
}
