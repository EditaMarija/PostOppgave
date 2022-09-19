using System.Text.RegularExpressions;
using System.Text.Json;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using PostOppgave;

namespace PostOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert JSON to C#
            string verkstedJsonData = File.ReadAllText("Verksted.json");
            var verksted = JsonConvert.DeserializeObject<Verkstedet[]>(verkstedJsonData, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            //Welcome to the app
            Console.WriteLine("Hei og velkommen! Tast inn postnummer:");
            int brukerSvar = int.Parse(Console.ReadLine());
            Console.WriteLine("Velg godkjenningstyper:");
            var brukerValg = Console.ReadLine().ToUpper();

            if (verksted != null)
            {
                foreach (var verkstedet in verksted)
                {
                                       
                    //neste steg: å la bruker velge flere godkjenningstyper
                    if (verkstedet.Postnummer == brukerSvar
                        && verkstedet.Postnummer.GetType() != typeof(string) 
                        && verkstedet.Godkjenningstyper.Contains(brukerValg))
                    {
                        verkstedet.PrintVerksted();
                    }

                }
            }

            //Console.WriteLine(verkstedJsonData);
            Console.Read();
        }
    }
}

