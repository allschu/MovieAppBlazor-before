namespace MovieAppBlazor.Data.Interfaces
{
    public interface ICastService
    {
        Task<ICollection<Cast>> GetCastAsync(int id, CancellationToken cancellationToken = default);
    }
}
