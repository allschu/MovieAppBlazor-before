using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MovieAppBlazor.Data
{
    public class CastService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public CastService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri(_configuration["CastFunctionApiUrl"]);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ICollection<Cast>> GetCastAsync(int id, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"GetMovieCastFunction?id={id}", cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                // _logger.LogError($"HTTP ERROR: {response.ReasonPhrase}");
            }

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var resultSelection = JsonConvert.DeserializeObject<CastResultSelection>(content);

            return resultSelection.cast;
        }
    }
}
