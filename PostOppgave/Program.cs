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
            FylkerList.Add(new Fylke(4, "Hedmark", 2100, 2599));
            FylkerList.Add(new Fylke(5, "Oppland", 2600, 2999));
            FylkerList.Add(new Fylke(5, "Oppland", 3550, 3599));
            FylkerList.Add(new Fylke(6, "Buskerud", 3000, 3049));
            FylkerList.Add(new Fylke(6, "Buskerud", 3300, 3549));
            FylkerList.Add(new Fylke(7, "Vestfold", 3050, 3299));
            FylkerList.Add(new Fylke(8, "Telemark", 3600, 3999));
            FylkerList.Add(new Fylke(9, "Rogaland", 4000, 4399));
            FylkerList.Add(new Fylke(10, "Vest-Agder", 4400, 4699));
            FylkerList.Add(new Fylke(11, "Aust-Agder", 4700, 4999));
            FylkerList.Add(new Fylke(12, "Hordaland", 5000, 5499));
            FylkerList.Add(new Fylke(12, "Hordaland", 5550, 5749));
            FylkerList.Add(new Fylke(12, "Hordaland", 5800, 5949));
            FylkerList.Add(new Fylke(13, "Rogaland", 5500, 5549));
            FylkerList.Add(new Fylke(14, "Sogn og Fjordane", 5750, 5799));
            FylkerList.Add(new Fylke(14, "Sogn og Fjordane", 5950, 5999));
            FylkerList.Add(new Fylke(14, "Sogn og Fjordane", 6700, 6999));
            FylkerList.Add(new Fylke(15, "Møre og Romsdal", 6000, 6699));
            FylkerList.Add(new Fylke(16, "Sør-Trøndelag", 7000, 7499));
            FylkerList.Add(new Fylke(16, "Sør-Trøndelag", 7700, 7749));
            FylkerList.Add(new Fylke(17, "Nord-Trøndelag", 7500, 7699));
            FylkerList.Add(new Fylke(17, "Nord-Trøndelag", 7750, 7949));
            FylkerList.Add(new Fylke(18, "Nordland", 7950, 8449));
            FylkerList.Add(new Fylke(18, "Nordland", 8500, 8999));
            FylkerList.Add(new Fylke(19, "Troms", 9000, 9149));
            FylkerList.Add(new Fylke(19,"Troms", 9200, 9499));
            FylkerList.Add(new Fylke(20, "Finnmark", 9150, 9199));
            FylkerList.Add(new Fylke(20,"Finnmark", 9500, 9999));
           
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





