
namespace PostOppgave
{
    class Program
    {   
        static void Main(string[] args)
        {
            var garageCollection = new GarageCollection();
            Console.WriteLine("Hei og velkommen! Velg 1 eller 2");
            MainMenu(garageCollection);

        }

        //next: combine menu 1 and 2,to find garages with selected types in chosen county
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
                    garages.GetResults();
                    garages.FilterGarages();
                    garages.PrintFilteredGarages();
   
                    //garages.ShowFilteredTypes(brukerValg);                    
                    break;
            }
        }

        static void ShowCounties(List<County> countyList)
        {
            Console.Clear();
            Console.WriteLine("Velg ditt fylke:");
           
            foreach (var county in countyList)
            {
                Console.WriteLine($"{county.Idnr}. " + county.Navn);
            }
        }


        static void ShowGarageTypes(List<Type> typeList)
        {
            Console.Clear();
            Console.WriteLine("Velg godkjenningstyper:");
            
            foreach (var type in typeList)
            {
                Console.WriteLine($"{type.TypeId}. " + type.TypeNavn);
            }
        }

    }
}

          

