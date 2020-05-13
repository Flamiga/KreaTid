using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class Produkt
    {
        //fields
        public int ProduktId { get; set; }

        public string ProduktNavn { get; set; }

        public decimal ProduktPris { get; set; }
        //ProduktImg: <list>Produkt(string(url))

        //constructor

        public Produkt() { }

        public Produkt(int produktId, string produktNavn, decimal produktPris)
        {
            ProduktId = produktId;
            ProduktNavn = produktNavn;
            ProduktPris = produktPris;
        }

    }
}
