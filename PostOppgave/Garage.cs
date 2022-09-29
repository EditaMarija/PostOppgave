using Newtonsoft.Json;
    public class Garage
    {
        public string? Bedriftsnavn { get; set; }
        public string? Adresse { get; set; }

        [JsonProperty("Postnummer")]
        public int Postnummer { get; set; }
        public string? Poststed { get; set; }
        public string? Godkjenningstyper { get; set; }
        public int Organisasjonsnummer { get; set; }
        //[JsonIgnore]
        public int Godkjenningsnummer { get; set; }

        public void PrintGarage()
        {
            Console.WriteLine(Bedriftsnavn);
            Console.WriteLine(Adresse);
            Console.WriteLine(Poststed);
            Console.WriteLine(Postnummer);
            Console.WriteLine(Godkjenningstyper);
            Console.WriteLine(Organisasjonsnummer);
            Console.WriteLine(Godkjenningsnummer + " \n ");
        }


    //public void PrintVerksted()
    //{
    //    Console.WriteLine( 
    //               $" \n" +
    //               $"{Bedriftsnavn} \n " +
    //               $"{Adresse} \n " +
    //               $"{Postnummer} \n " +
    //               $"{Poststed} \n " +
    //               $"{Godkjenningstyper} \n " +
    //               $"{Organisasjonsnummer} \n " +
    //               $"{Godkjenningsnummer}");
    //    Console.WriteLine();
    //}


}


