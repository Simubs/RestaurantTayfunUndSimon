using System.Runtime.CompilerServices;

namespace Restaurant.Entitys
{
    public class KartenElement
    {
        public KartenElement(int KartenElementNr, string ElemName, double Preis, int ElementArtNr) {
        this.ElementArtNr = ElementArtNr;
        this.Preis = Preis;
            this.KartenElementNr = KartenElementNr;
            this.ElemName = ElemName;
        }

        public int KartenElementNr { get; set; }

        public string ElemName { get; set; } 

        public double Preis { get; set; }

        public int ElementArtNr { get; set; }

    }
}