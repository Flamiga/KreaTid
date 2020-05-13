using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class Kategori
    {

        //fields
        public int KategoriId { get; set; }

        public string KategoriNavn { get; set; }

        // constructor 

        public Kategori() { }

        public Kategori(int kategoriId, string kategoriNavn)
        {
            KategoriId = kategoriId;
            KategoriNavn = kategoriNavn;
        }
    }
}
