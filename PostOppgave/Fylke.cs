using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOppgave
{
    public class Fylke
    {
        public int Idnr { get; set; }
        public string? Navn { get; set; }
        public int FraPostnr { get; set; }
        public int TilPostnr { get; set; }

        public Fylke()
        {

        }
        public Fylke(int idnr, string? navn, int fraPostnr, int tilPostnr)
        {
            Idnr = idnr;
            Navn = navn;
            FraPostnr = fraPostnr;
            TilPostnr = tilPostnr;
        }

        static Fylke[] FylkerArray = new Fylke[]
             {
            new Fylke(1, "Oslo", 0000, 1300),
            new Fylke(2, "Akershus", 1300, 1500),
            new Fylke(3, "Østfold", 1500, 1900),
            new Fylke(2, "Akershus", 1900, 2100),
            new Fylke(4, "Hedmark", 2100, 2600),
            new Fylke(5, "Oppland", 2600, 3000),
            new Fylke(5, "Oppland", 3550, 3600),
            new Fylke(6, "Buskerud", 3000, 3050),
            new Fylke(6, "Buskerud", 3300, 3550),
            new Fylke(7, "Vestfold", 3050, 3300),
            new Fylke(8, "Telemark", 3600, 4000),
            new Fylke(9, "Rogaland", 4000, 4400),
            new Fylke(10, "Vest-Agder", 4400, 4700),
            new Fylke(11, "Aust-Agder", 4700, 5000),
            new Fylke(12, "Hordaland", 5000, 5500),
            new Fylke(12, "Hordaland", 5550, 5750),
            new Fylke(12, "Hordaland", 5800, 5950),
            new Fylke(9, "Rogaland", 5500, 5550),
            new Fylke(13, "Sogn og Fjordane", 5750, 5800),
            new Fylke(13, "Sogn og Fjordane", 5950, 6000),
            new Fylke(13, "Sogn og Fjordane", 6700, 7000),
            new Fylke(14, "Møre og Romsdal", 6000, 6700),
            new Fylke(15, "Sør-Trøndelag", 7000, 7500),
            new Fylke(15, "Sør-Trøndelag", 7700, 7750),
            new Fylke(16, "Nord-Trøndelag", 7500, 7700),
            new Fylke(16, "Nord-Trøndelag", 7750, 7950),
            new Fylke(17, "Nordland", 7950, 8450),
            new Fylke(17, "Nordland", 8500, 9000),
            new Fylke(18, "Troms", 9000, 91450),
            new Fylke(18, "Troms", 9200, 9500),
            new Fylke(19, "Finnmark", 9150, 9200),
            new Fylke(19, "Finnmark", 9500, 9999),
             };

    }
}

/*
00–12 Oslo
13–15 Akershus
15–18 Østfold
19–21 Akershus
21–26 Hedmark
26–29 Oppland
30       Buskerud
30–32 Vestfold
33–36 Buskerud
35       Oppland
36–39 Telemark
40–44 Rogaland
44–47 Vest - Agder
47–49 Aust - Agder
50–59 Hordaland
55       Rogaland
57, 59 Sogn og Fjordane
60–66 Møre og Romsdal
67–69 Sogn og Fjordane
70–75 Sør-Trøndelag
75–76 Nord-Trøndelag
77       Sør-Trøndelag
77–79 Nord-Trøndelag
79–89 Nordland
84, 90–94 Troms
91, 95–99 Finnmark
*/
