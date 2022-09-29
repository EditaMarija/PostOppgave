using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOppgave
{
    public class Type
    {
        public int TypeId { get; set; }
        public string? TypeNavn { get; set; }
        
        public Type()
        {
        }
        public Type(int typeId, string? typeNavn)
        {
            TypeId = typeId;
            TypeNavn = typeNavn;
  
        }

        //static Type[] TypeArray = new Type[]
        //    {
        //    new Type(1, "BILVERKSTED01"),
        //    new Type(2, "BILVERKSTED02"),
        //    new Type(3, "BILVERKSTED03"),
        //    new Type(4, "BILVERKSTED01B"),
        //    new Type(5, "BILVERKSTEDALLE"),
        //    new Type(6, "BILGLASS"),
        //    new Type(7, "KONTROLLORGAN01"),
        //    new Type(8, "KONTROLLORGAN02"),
        //    new Type(9, "KONTROLLORGAN03"),
        //    new Type(10, "KONTROLLORGAN04"),
        //    new Type(11, "BILVERKSTED"),
        //    new Type(12, "FARTSSKRIVER"),
        //    new Type(13, "TRAKTOR"),
        //    new Type(14, "ALKOLASVERKSTED"),
        //    new Type(15, "SKADEVERKSTED01"),
        //    new Type(16, "SKADEVERKSTED02"),
        //    new Type(17, "MOTORSYKKELOGMOPED"),
        //    new Type(18, "HJUL"),
        //    new Type(19, "BILSKADE"),
        //    new Type(20, "HENGERESPALOPSBREMSEANLEGG"),
        //    new Type(21, "PABYGGER"),
        //    new Type(22, "HJULUTRUSTNING"),
        //    new Type(23, "EKSOSANLEGG"),
        //    new Type(24, "LYSUTSTYR"),
        //};

        /*
            Bilverksted 
            Bilverksted 01 
            Bilverksted 01 
            Bilverksted 02 
            Bilverksted 03 
            Motorsykkel- og mopedverksted 
            Bilskadeverksted  
            Skadeverksted 01 
            Skadeverksted 02 
                Bilelektro-/drivstoffanleggverksted 
                Bilbremseverksted  
                Bildieselverksted 
            Hjulutrustningsverksted 
            Påbyggerverksted
            Traktorverksted  
            Alkolåsverksted
        */


    }
}
