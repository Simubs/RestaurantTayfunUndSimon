using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFixedView.Entities
{
    public class Bestellung
    {
        public int Bestell_Nr {  get; set; }
        public int Rechnungs_Nr {  get; set; }
        public String Besonderheiten {  get; set; }
        
        public int K_Elem_Nr {  get; set; }

    }
}
