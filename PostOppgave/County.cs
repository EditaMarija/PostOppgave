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

        //static County[] FylkerArray = new County[]
        //     {
        //    new County(1, "Oslo", 0000, 1300),
        //    new County(2, "Akershus", 1300, 1500),
        //    new County(3, "Østfold", 1500, 1900),
        //    new County(2, "Akershus", 1900, 2100),
        //    new County(4, "Hedmark", 2100, 2600),
        //    new County(5, "Oppland", 2600, 3000),
        //    new County(5, "Oppland", 3550, 3600),
        //    new County(6, "Buskerud", 3000, 3050),
        //    new County(6, "Buskerud", 3300, 3550),
        //    new County(7, "Vestfold", 3050, 3300),
        //    new County(8, "Telemark", 3600, 4000),
        //    new County(9, "Rogaland", 4000, 4400),
        //    new County(10, "Vest-Agder", 4400, 4700),
        //    new County(11, "Aust-Agder", 4700, 5000),
        //    new County(12, "Hordaland", 5000, 5500),
        //    new County(12, "Hordaland", 5550, 5750),
        //    new County(12, "Hordaland", 5800, 5950),
        //    new County(9, "Rogaland", 5500, 5550),
        //    new County(13, "Sogn og Fjordane", 5750, 5800),
        //    new County(13, "Sogn og Fjordane", 5950, 6000),
        //    new County(13, "Sogn og Fjordane", 6700, 7000),
        //    new County(14, "Møre og Romsdal", 6000, 6700),
        //    new County(15, "Sør-Trøndelag", 7000, 7500),
        //    new County(15, "Sør-Trøndelag", 7700, 7750),
        //    new County(16, "Nord-Trøndelag", 7500, 7700),
        //    new County(16, "Nord-Trøndelag", 7750, 7950),
        //    new County(17, "Nordland", 7950, 8450),
        //    new County(17, "Nordland", 8500, 9000),
        //    new County(18, "Troms", 9000, 9150),
        //    new County(18, "Troms", 9200, 9500),
        //    new County(19, "Finnmark", 9150, 9200),
        //    new County(19, "Finnmark", 9500, 9999),
        //     };

    }
}

