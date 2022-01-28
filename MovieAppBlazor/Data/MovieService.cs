using MovieAppBlazor.Data.Interfaces;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MovieAppBlazor.Data
{
    public class MovieService : IMovieService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public MovieService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri(_configuration["MovieApiUrl"]);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<MovieResultSelection> GetTrendingMovies(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("Movie/trending", cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                //_logger.LogError($"HTTP ERROR: {response.ReasonPhrase}");
            }

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<MovieResultSelection>(content);
        }

        public async Task<MovieDetail> GetMovieDetailAsync(int id, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"Movie/{id}", cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
               // _logger.LogError($"HTTP ERROR: {response.ReasonPhrase}");
            }

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<MovieDetail>(content);
        }
    }
}
