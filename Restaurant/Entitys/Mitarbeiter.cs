using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entitys
{
    public class Mitarbeiter
    {

        public Mitarbeiter(String mitarbeiternummer, String vorname, String nachname, int taetigkeitsbereich) {
            this.mitarbeiternummer = mitarbeiternummer;
            this.vorname = vorname; 
            this.nachname = nachname;
            this.taetigkeitsbereich = taetigkeitsbereich;
        
        }
        public int mitarbeiternummer { get; set; }

        public String vorname { get; set; }

        public String nachname { get; set; }

        public int taetigkeitsbereich { get; set; }
    }
}
