namespace MovieAppBlazor.Data.Interfaces
{
    public interface IMovieService
    {
        Task<MovieResultSelection> GetTrendingMovies(CancellationToken cancellationToken = default);
        Task<MovieDetail> GetMovieDetailAsync(int id, CancellationToken cancellationToken = default);
    }
}
