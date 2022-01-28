namespace MovieAppBlazor.Data
{
    public class CastResultSelection
    {
        public int id { get; set; }
        public ICollection<Cast> cast { get; set; }
    }
}
