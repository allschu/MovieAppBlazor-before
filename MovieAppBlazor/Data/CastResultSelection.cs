namespace MovieAppBlazor.Data
{
    public class CastResultSelection
    {
        public int Id { get; set; }
        public ICollection<Cast> Cast { get; set; }
    }
}
