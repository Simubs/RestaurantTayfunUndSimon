﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entitys
{
    class Bestellung
    {
        public int BestellNr { get; set; }
        public int RechnungNr { get; set; }

        public KartenElement KartenElement {get;set;}
        public int KartenElementNr { get;set;}
    }
}