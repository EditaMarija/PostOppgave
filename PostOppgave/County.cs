using PostOppgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOppgave
{
    public class County
    {
        public int Idnr { get; set; }
        public string? Navn { get; set; }
        public int FraPostnr { get; set; }
        public int TilPostnr { get; set; }

        public County()
        {
        }
        public County(int idnr, string? navn, int fraPostnr, int tilPostnr)
        {
            Idnr = idnr;
            Navn = navn;
            FraPostnr = fraPostnr;
            TilPostnr = tilPostnr;
        }

    }
}

