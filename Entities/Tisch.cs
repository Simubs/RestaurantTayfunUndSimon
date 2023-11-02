using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFixedView.Entities
{
    public class Tisch
    {
        public int Id { get; set; }
        public int Sitzplaetze { get; set; }

        public int Personal_NR { get; set; }


        public Tisch(int id, int sitzplaetze, int personal_NR)
        {
            Id = id;
            Sitzplaetze = sitzplaetze;
            Personal_NR = personal_NR;
        }
    }
}
