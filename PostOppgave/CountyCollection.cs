using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOppgave
{
    public class CountyCollection
    {
        public List<County> CountyList = new();
        public CountyCollection()
        {
            CountyList.Add(new County(1, "Oslo", 0000, 1300));
            CountyList.Add(new County(2, "Akershus", 1300, 1500));
            CountyList.Add(new County(3, "Østfold", 1500, 1900));
            CountyList.Add(new County(2, "Akershus", 1900, 2100));
            CountyList.Add(new County(4, "Hedmark", 2100, 2600));
            CountyList.Add(new County(5, "Oppland", 2600, 3000));
            CountyList.Add(new County(5, "Oppland", 3550, 3600));
            CountyList.Add(new County(6, "Buskerud", 3000, 3050));
            CountyList.Add(new County(6, "Buskerud", 3300, 3550));
            CountyList.Add(new County(7, "Vestfold", 3050, 3300));
            CountyList.Add(new County(8, "Telemark", 3600, 4000));
            CountyList.Add(new County(9, "Rogaland", 4000, 4400));
            CountyList.Add(new County(10, "Vest-Agder", 4400, 4700));
            CountyList.Add(new County(11, "Aust-Agder", 4700, 5000));
            CountyList.Add(new County(12, "Hordaland", 5000, 5500));
            CountyList.Add(new County(12, "Hordaland", 5550, 5750));
            CountyList.Add(new County(12, "Hordaland", 5800, 5950));
            CountyList.Add(new County(9, "Rogaland", 5500, 5549));
            CountyList.Add(new County(13, "Sogn og Fjordane", 5750, 5800));
            CountyList.Add(new County(13, "Sogn og Fjordane", 5950, 6000));
            CountyList.Add(new County(13, "Sogn og Fjordane", 6700, 7000));
            CountyList.Add(new County(14, "Møre og Romsdal", 6000, 6700));
            CountyList.Add(new County(15, "Sør-Trøndelag", 7000, 7500));
            CountyList.Add(new County(15, "Sør-Trøndelag", 7700, 7750));
            CountyList.Add(new County(16, "Nord-Trøndelag", 7500, 7700));
            CountyList.Add(new County(16, "Nord-Trøndelag", 7750, 7950));
            CountyList.Add(new County(17, "Nordland", 7950, 8450));
            CountyList.Add(new County(17, "Nordland", 8500, 9000));
            CountyList.Add(new County(18, "Troms", 9000, 9150));
            CountyList.Add(new County(18, "Troms", 9200, 9500));
            CountyList.Add(new County(19, "Finnmark", 9150, 9200));
            CountyList.Add(new County(19, "Finnmark", 9500, 9999));
        }

        public County? FilterCounty(int brukerValg)
        {

            foreach (var fylke in CountyList)
            {

                if (brukerValg == fylke.Idnr)
                {

                    //Console.Clear();
                    //Console.WriteLine($"Bilverksteder i {fylke.Navn} fylke: \n ");

                    //ShowResultCounty(fylke);
                    return fylke;

                    //her kan vi hente ut postnr fra og til,eller array..split()
                    //return fylke.FraPostnr + fylke.TilPostnr
                }

            }

            return null;
        }

        

    }
}
