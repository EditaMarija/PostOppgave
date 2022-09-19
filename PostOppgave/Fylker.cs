using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOppgave
{
    internal class Fylker
    {
        public int ValgtPostnummer { get; set; }
        public string? ValgtPoststed { get; set; }

        //finne hvilken fylke brukeren har valgt, neste: finne bedre måte
        public void GetFylke()
        {
            if (ValgtPostnummer <= 1200)
            {
                //ValgtPoststed == "Oslo"
                //Verkstedet.PrintVerksted();
            }
            else if (ValgtPostnummer >= 1300 && ValgtPostnummer <= 1500)
            {
                //ValgtPoststed == "Akershus"
                //Verkstedet.PrintVerksted();
            }
            else if (ValgtPostnummer >= 1500 && ValgtPostnummer <= 1800)
            {
                //ValgtPoststed == "Østfold"
                //Verkstedet.PrintVerksted();
            }
        }
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
