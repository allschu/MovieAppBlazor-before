namespace MovieAppBlazor.Data.Interfaces
{
    public interface ICastService
    {
        Task<CastResultSelection> GetCastAsync(int id, CancellationToken cancellationToken = default);
    }
}
