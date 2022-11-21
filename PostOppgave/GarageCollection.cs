using Newtonsoft.Json;
using System.Data;
using System.Linq;

namespace PostOppgave
{
    public class GarageCollection
    {
        public List<Type>? TypeList = new List<Type>();
        public List<Garage>? GarageList = new List<Garage>();
        public CountyCollection _countyCollection;
        public List<Garage>? ListOfFilteredGarages = new List<Garage>();

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

        //show garages in selected county
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

        //get selected types from client(input) and put them into new list(listMedValg)
        public List<int> listeMedValg = new List<int>();
        public List<string> valgteVerkstedOrd = new List<string>();

        public void GetResults()
        {
            while (listeMedValg.Count < 3)
            {
                Console.WriteLine("Skriv inn Godkjenningstype(nummer):");
                int input = int.Parse(Console.ReadLine());
                if (!listeMedValg.Contains(input))
                {
                    listeMedValg.Add(input);
                }
                Console.WriteLine("Ønsker du å legge til ett tall til ? (n = nei) og (j = ja) ");
                var input2 = Console.ReadLine();
                if (input2.ToLower() == "n") break;
            }
        }

        //filter list with selected types and add to list of filtered garages
        public void FilterGarages()
        {
            foreach (var valg in listeMedValg)
            {
                TurnNumbersToNames(valg);
            }

            LoopThroughAllGarages();
        }

        public void TurnNumbersToNames(int number)
        {
            foreach (var type in TypeList)
            {
                if (number == type.TypeId) valgteVerkstedOrd.Add(type.TypeNavn);
            }
                    
        }

        public void LoopThroughAllGarages()
        {
            foreach (var garage in GarageList)
            {
                if (valgteVerkstedOrd.Count == 1 && garage.Godkjenningstyper.Contains(valgteVerkstedOrd[0]))
                {
                    AddGarageToFilteredList(garage);
                }

                if (valgteVerkstedOrd.Count == 2 && (garage.Godkjenningstyper.Contains(valgteVerkstedOrd[0]) &&
                                                     garage.Godkjenningstyper.Contains(valgteVerkstedOrd[1])))
                {
                    AddGarageToFilteredList(garage);
                }

                if (valgteVerkstedOrd.Count == 3 && (garage.Godkjenningstyper.Contains(valgteVerkstedOrd[0]) &&
                                                     garage.Godkjenningstyper.Contains(valgteVerkstedOrd[1]) &&
                                                     garage.Godkjenningstyper.Contains(valgteVerkstedOrd[2])))
                {
                    AddGarageToFilteredList(garage);
                }

            }
        }

        public void AddGarageToFilteredList(Garage garage)
        {
            if (!ListOfFilteredGarages.Contains(garage))
            {
                ListOfFilteredGarages.Add(garage);
            }
        }

        //shows garages with multiple types
        public void PrintFilteredGarages()
        {
            Console.Clear();
            Console.WriteLine($"Bilverksteder med din valgt godkjenning: \n ");
            foreach (var garage in ListOfFilteredGarages)
            {
                garage.PrintGarage();
            }
        }

        //shows garages with only one type
        public int? ShowFilteredTypes(int brukerValg)
        {
            foreach (var type in TypeList)
            {
                if (type.TypeId == brukerValg)
                {                  
                    Console.Clear();                   
                    Console.WriteLine($"Bilverksteder med {type.TypeNavn} godkjenning: \n ");
                    // return list of garages with selected type
                    foreach (var garage in GarageList)
                    {
                        //if(garage.Godkjenningstyper.Contains((char)brukerValg))
                        if (garage.Godkjenningstyper.Contains(type.TypeNavn))
                        {
                            garage.PrintGarage();
                        }
                       
                    }
                }
            }

            return null;
        }      

    }
}
