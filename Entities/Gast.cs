using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFixedView.Entities
{
    public class Gast
    {
        public int Id { get; set; }
        public int Anzahl { get; set; }
        public int Rechnungs_Nr { get; set; }

        public int Tisch_Nr { get; set; }

        public Gast(int id, int anzahl, int rechnungs_Nr, int tisch_Nr)
        {
            Id = id;
            this.Anzahl = anzahl;
            Rechnungs_Nr = rechnungs_Nr;
            Tisch_Nr = tisch_Nr;
        }
    }
}
