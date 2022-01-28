using MovieAppBlazor.Data.Interfaces;
using System.Net.Http.Headers;

namespace MovieAppBlazor.Data
{
    public class CastService : ICastService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public CastService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri(_configuration["MovieApiUrl"]);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public Task<CastResultSelection> GetCastAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
