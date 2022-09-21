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
            new Fylke(3, "Østfold", 1500, 1899),
            new Fylke(2, "Akershus", 1900, 2099),
            new Fylke(4, "Hedmark", 2100, 2599),
            new Fylke(5, "Oppland", 2600, 2999),
            new Fylke(5, "Oppland", 3550, 3599),
            new Fylke(6, "Buskerud", 3000, 3049),
            new Fylke(6, "Buskerud", 3300, 3549),
            new Fylke(7, "Vestfold", 3050, 3299),
            new Fylke(8, "Telemark", 3600, 3999),
            new Fylke(9, "Rogaland", 4000, 4399),
            new Fylke(10, "Vest-Agder", 4400, 4699),
            new Fylke(11, "Aust-Agder", 4700, 4999),
            new Fylke(12, "Hordaland", 5000, 5499),
            new Fylke(12, "Hordaland", 5550, 5749),
            new Fylke(12, "Hordaland", 5800, 5949),
            new Fylke(13, "Rogaland", 5500, 5549),
            new Fylke(14, "Sogn og Fjordane", 5750, 5799),
            new Fylke(14, "Sogn og Fjordane", 5950, 5999),
            new Fylke(14, "Sogn og Fjordane", 6700, 6999),
            new Fylke(15, "Møre og Romsdal", 6000, 6699),
            new Fylke(16, "Sør-Trøndelag", 7000, 7499),
            new Fylke(16, "Sør-Trøndelag", 7700, 7749),
            new Fylke(17, "Nord-Trøndelag", 7500, 7699),
            new Fylke(17, "Nord-Trøndelag", 7750, 7949),
            new Fylke(18, "Nordland", 7950, 8449),
            new Fylke(18, "Nordland", 8500, 8999),
            new Fylke(19, "Troms", 9000, 9149),
            new Fylke(19, "Troms", 9200, 9499),
            new Fylke(20, "Finnmark", 9150, 9199),
            new Fylke(20, "Finnmark", 9500, 9999),
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
