using System.Text.RegularExpressions;
using System.Text.Json;
using Newtonsoft.Json;
using PostOppgave;


namespace PostOppgave
{
    class Program
    {
        static List<County> CountyList = new List<County>();
        static List<Type> TypeList = new List<Type>();
        //static List<Verkstedet> Verkstederlist = new List<Verkstedet>();
        static void Main(string[] args)
        {

            //convert JSON to C#
            string verkstedJsonData = File.ReadAllText("verksted.json");
            var verksted = JsonConvert.DeserializeObject<List<Garage>>(verkstedJsonData,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            //var verksteder = new GarageCollection();

            //Welcome to the app
            Console.WriteLine("Hei og velkommen!");
            

            MainMenu();
            ShowVerksted(verksted);

            


            Console.Read();
        }

        static void MainMenu()
        {
            Console.WriteLine("1: Søk på verksteder");
            Console.WriteLine("2: Søk på godkjenningstyper");
            ChosenMenu();
        }

        static void ChosenMenu()
        {
            
            switch (Console.ReadLine())
            {
                case "1":
                    AddCounty();
                    ShowFylkeMenu();
                    break;
                case "2":
                    AddTyper();
                    ShowGodkjenning();
                    break;
            }
        }

        static void ShowFylkeMenu()
        {
            Console.WriteLine("Velg ditt fylke:");
            foreach (var fylke in CountyCollection.CountyList)
            {
                Console.WriteLine($"{fylke.Idnr}. " + fylke.Navn);
            }

        }

        static void ShowVerksted(List<Garage> verkstederlist)
        {
            int brukerValg = int.Parse(Console.ReadLine());

            FilterFylke(verkstederlist, brukerValg);
        }

        static void FilterFylke(List<Garage> verkstederlist, int brukerValg)
        {
            
            foreach (var fylkene in CountyCollection.CountyList)
            {
                
                if (brukerValg == fylkene.Idnr)
                {
                    Console.Clear();
                    Console.WriteLine($"Bilverksteder i {fylkene.Navn} fylke: \n ");

                    
                    //var resultcounty = new GarageCollection();

                    ShowResultCounty(verkstederlist, fylkene);

                }
                
            }
            
        }

        static void ShowResultCounty(List<Garage> verkstederlist, County fylkene)
        {
            foreach (var verkstedene in verkstederlist)
            {
                if (verkstedene.Postnummer >= fylkene.FraPostnr && verkstedene.Postnummer <= fylkene.TilPostnr)
                {
                    verkstedene.PrintGarage();
                }
            }
        }

        static void AddCounty()
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

        static void ShowGodkjenning()
        {
            Console.WriteLine("Velg godkjenningstyper:");
            foreach (var type in TypeList)
            {
                Console.WriteLine($"{type.TypeId}. " + type.TypeNavn);
            }
        }

        static void AddTyper()
        {
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

    }
}
/*
            // Godkjenningstyper:
            //int brukerSvar = int.Parse(Console.ReadLine());
            //Console.WriteLine("Velg godkjenningstyper:");
            //var brukerValg = Console.ReadLine().ToUpper();
                                  
            //neste steg: å la bruker velge flere godkjenningstyper
            //string[] brukerValgene = brukerValg.Split(' ');

            //if (verksted != null)
            //{
            //    foreach (var verkstedet in verksted)
            //    {  
            //        if (verkstedet.Postnummer == brukerSvar
            //            && verkstedet.Postnummer.GetType() != typeof(string) 
            //            //&& verkstedet.Godkjenningstyper.Contains(brukerValg.ToString())
            //            && verkstedet.Godkjenningstyper.Contains(brukerValg)
            //            )
            //        {
            //            verkstedet.PrintVerksted();
            //        }
            //    }
            //}

            //Console.WriteLine(verkstedJsonData);

}  
*/





