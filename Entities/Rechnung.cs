using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFixedView.Entities
{
    public class Rechnung
    {
        public int Rechnungs_Nr {  get; set; }
        public double Betrag {  get; set; }
        public int Personal_Nr { get; set; }
        public double Trinkgeld { get; set; }
    }
}
