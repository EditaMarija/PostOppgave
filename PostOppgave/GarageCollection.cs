using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PostOppgave
{
    public class GarageCollection
    {
        static List<Type> TypeList = new();
        public List<Garage> GarageList = new List<Garage>();
        public CountyCollection _countyCollection;

        public GarageCollection()
        {
            _countyCollection = new CountyCollection();
            string verkstedJsonData = File.ReadAllText("verksted.json");
            GarageList = JsonConvert.DeserializeObject<List<Garage>>(verkstedJsonData,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            TypeList.Add(new Type(1, "BILVERKSTED01"));
            TypeList.Add(new Type(2, "BILVERKSTED02"));
            TypeList.Add(new Type(3, "BILVERKSTED03"));
            TypeList.Add(new Type(4, "BILVERKSTED01B"));
            TypeList.Add(new Type(5, "BILVERKSTEDALLE"));
            TypeList.Add(new Type(6, "BILGLASS"));
            TypeList.Add(new Type(7, "KONTROLLORGAN01"));
            TypeList.Add(new Type(8, "KONTROLLORGAN02"));
            TypeList.Add(new Type(9, "KONTROLLORGAN03"));
            TypeList.Add(new Type(10, "KONTROLLORGAN04"));
            TypeList.Add(new Type(11, "BILVERKSTED"));
            TypeList.Add(new Type(12, "FARTSSKRIVER"));
            TypeList.Add(new Type(13, "TRAKTOR"));
            TypeList.Add(new Type(14, "ALKOLASVERKSTED"));
            TypeList.Add(new Type(15, "SKADEVERKSTED01"));
            TypeList.Add(new Type(16, "SKADEVERKSTED02"));
            TypeList.Add(new Type(17, "MOTORSYKKELOGMOPED"));
            TypeList.Add(new Type(18, "HJUL"));
            TypeList.Add(new Type(19, "BILSKADE"));
            TypeList.Add(new Type(20, "HENGERESPALOPSBREMSEANLEGG"));
            TypeList.Add(new Type(21, "PABYGGER"));
            TypeList.Add(new Type(22, "HJULUTRUSTNING"));
            TypeList.Add(new Type(23, "EKSOSANLEGG"));
            TypeList.Add(new Type(24, "LYSUTSTYR"));

        }

        public void ShowResultCounty(County county)
        {
            foreach (var garage in GarageList)
            {
                if (garage.Postnummer >= county.FraPostnr && garage.Postnummer <= county.TilPostnr)
                {
                    garage.PrintGarage();
                }
            }
        }
        //static void ShowVerksted(int brukerValg)
        //{
        //    int brukerValg = int.Parse(Console.ReadLine());
        //    var county = new CountyCollection();
        //    county.FilterCounty(brukerValg);
        //}

        //public void ShowResultCounty(County counties, int brukerSvar )
        //{
        //    foreach (var garage in GarageList)
        //    {
        //        if (garage.Postnummer >= counties.FraPostnr && garage.Postnummer <= counties.TilPostnr)
        //        {
        //            garage.PrintGarage();
        //        }
        //    }
        //}


    }
}
