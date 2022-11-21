
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

    }
}
