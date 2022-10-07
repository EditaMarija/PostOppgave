using System.Text.RegularExpressions;
using System.Text.Json;
using Newtonsoft.Json;
using PostOppgave;


namespace PostOppgave
{
    class Program
    {
        //static List<Type> TypeList = new ();
        
        static void Main(string[] args)
        {
            //Welcome to the app
            var garageCollection = new GarageCollection();
            Console.WriteLine("Hei og velkommen!");

            MainMenu(garageCollection);

            //Console.Read();
        }

        static void MainMenu(GarageCollection c)
        {
            Console.WriteLine("1: Søk på verksteder");
            Console.WriteLine("2: Søk på godkjenningstyper");
            ChosenMenu(c);
        }
        static void ChosenMenu(GarageCollection garages)
        {
            
            switch (Console.ReadLine())
            {
                case "1":
                    
                    ShowCounties(garages._countyCollection.CountyList);
                    var brukerSvar = int.Parse(Console.ReadLine());
                    var selectedCounty = garages._countyCollection.FilterCounty(brukerSvar);
                    garages.ShowResultCounty(selectedCounty);
                    break;

                case "2":
   
                    ShowGarageTypes(garages.TypeList);
                    var brukerValg = int.Parse(Console.ReadLine());
                    garages.ShowFilteredTypes(brukerValg);
                    //garages.ShowFilteredTypes(brukerValg, selectedCounty);

                    break;
            }
        }

        static void ShowCounties(List<County> countyList)
        {
            Console.WriteLine("Velg ditt fylke:");
           
            foreach (var county in countyList)
            {
                Console.WriteLine($"{county.Idnr}. " + county.Navn);
            }
        }


        static void ShowGarageTypes(List<Type> typeList)
        {
            Console.WriteLine("Velg godkjenningstyper:");
            
            foreach (var type in typeList)
            {
                Console.WriteLine($"{type.TypeId}. " + type.TypeNavn);
            }
        }

    }
}

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







