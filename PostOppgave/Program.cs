using System.Text.RegularExpressions;
using System.Text.Json;
using Newtonsoft.Json;

namespace PostOppgave
{
    internal class Program
    {
        static List<Fylke> FylkerList = new List<Fylke>();
        //static List<Verkstedet> VerkstedList = new List<Verkstedet>();
        static void Main(string[] args)
        {
            //convert JSON to C#
            string verkstedJsonData = File.ReadAllText("verksted.json");
            //var verksted = JsonConvert.DeserializeObject<Verkstedet[]>(verkstedJsonData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var verksted = JsonConvert.DeserializeObject<List<Verkstedet>>(verkstedJsonData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            //Welcome to the app
            Console.WriteLine("Hei og velkommen!");
            //string? brukerSvar = Console.ReadLine().ToUpper();

            AddFylker();
            ShowMenu();
            ShowVerksted(verksted);

            Console.Read();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Velg ditt fylke:");
            for (int i = 0; i < FylkerList.Count; i++)
            {
                Console.WriteLine($"{FylkerList[i].Idnr}. " + FylkerList[i].Navn);
            }
        }

        static void ShowVerksted(List<Verkstedet> verkstederlist)
        { 
            int brukerValg = int.Parse(Console.ReadLine());

            foreach (var fylkene in FylkerList)
            {
                if (brukerValg == fylkene.Idnr)
                {
                    Console.Clear();
                    Console.WriteLine($"Bilverksteder i {fylkene.Navn} fylke: \n ");
                    foreach (var verkstedene in verkstederlist)
                    {
                        if (verkstedene.Postnummer >= fylkene.FraPostnr && verkstedene.Postnummer <= fylkene.TilPostnr)
                        {
                            Console.WriteLine(verkstedene.Bedriftsnavn);
                            Console.WriteLine(verkstedene.Adresse);
                            Console.WriteLine(verkstedene.Poststed);
                            Console.WriteLine(verkstedene.Postnummer);
                            Console.WriteLine(verkstedene.Godkjenningstyper);
                            Console.WriteLine(verkstedene.Organisasjonsnummer);
                            Console.WriteLine(verkstedene.Godkjenningsnummer + " \n ");
                        }
                    }
                }
            }
        }

        static void AddFylker()
        {
            FylkerList.Add(new Fylke(1, "Oslo", 0000, 1300));
            FylkerList.Add(new Fylke(2, "Akershus", 1300, 1500));
            FylkerList.Add(new Fylke(3, "Østfold", 1500, 1900));
            FylkerList.Add(new Fylke(2, "Akershus", 1900, 2100));
            FylkerList.Add(new Fylke(4, "Hedmark", 2100, 2600));
            FylkerList.Add(new Fylke(5, "Oppland", 2600, 3000));
            FylkerList.Add(new Fylke(5, "Oppland", 3550, 3600));
            FylkerList.Add(new Fylke(6, "Buskerud", 3000, 3050));
            FylkerList.Add(new Fylke(6, "Buskerud", 3300, 3550));
            FylkerList.Add(new Fylke(7, "Vestfold", 3050, 3300));
            FylkerList.Add(new Fylke(8, "Telemark", 3600, 4000));
            FylkerList.Add(new Fylke(9, "Rogaland", 4000, 4400));
            FylkerList.Add(new Fylke(10, "Vest-Agder", 4400, 4700));
            FylkerList.Add(new Fylke(11, "Aust-Agder", 4700, 5000));
            FylkerList.Add(new Fylke(12, "Hordaland", 5000, 5500));
            FylkerList.Add(new Fylke(12, "Hordaland", 5550, 5750));
            FylkerList.Add(new Fylke(12, "Hordaland", 5800, 5950));
            FylkerList.Add(new Fylke(9, "Rogaland", 5500, 5549));
            FylkerList.Add(new Fylke(13, "Sogn og Fjordane", 5750, 5800));
            FylkerList.Add(new Fylke(13, "Sogn og Fjordane", 5950, 6000));
            FylkerList.Add(new Fylke(13, "Sogn og Fjordane", 6700, 7000));
            FylkerList.Add(new Fylke(14, "Møre og Romsdal", 6000, 6700));
            FylkerList.Add(new Fylke(15, "Sør-Trøndelag", 7000, 7500));
            FylkerList.Add(new Fylke(15, "Sør-Trøndelag", 7700, 7750));
            FylkerList.Add(new Fylke(16, "Nord-Trøndelag", 7500, 7700));
            FylkerList.Add(new Fylke(16, "Nord-Trøndelag", 7750, 7950));
            FylkerList.Add(new Fylke(17, "Nordland", 7950, 8450));
            FylkerList.Add(new Fylke(17, "Nordland", 8500, 9000));
            FylkerList.Add(new Fylke(18, "Troms", 9000, 9150));
            FylkerList.Add(new Fylke(18,"Troms", 9200, 9500));
            FylkerList.Add(new Fylke(19, "Finnmark", 9150, 9200));
            FylkerList.Add(new Fylke(19,"Finnmark", 9500, 9999));
           
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
            //            //&& verkstedet.Postnummer.GetType() != typeof(string) 
            //            //&& verkstedet.Godkjenningstyper.Contains(brukerValg.ToString())
            //            //&& verkstedet.Godkjenningstyper.Contains(brukerValg)
            //            )
            //        {
            //            verkstedet.PrintVerksted();
            //        }
            //    }
            //}

            //Console.WriteLine(verkstedJsonData);

}  
*/





