using Newtonsoft.Json;

namespace CurrencyConverter.Infra.Integration
{
    public class BaseClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;

        public BaseClient(string httpClient, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient(httpClient);
        }
        public async Task<T> Get<T>(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(string.Format(url));
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(result, new JsonSerializerSettings { MetadataPropertyHandling = MetadataPropertyHandling.Ignore });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
