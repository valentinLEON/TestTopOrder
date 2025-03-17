using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TestTopOrder.Data.Contracts;

namespace TestTopOrder.Data
{
    public class CountriesService(HttpClient httpClient) : ICountriesService
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = false };

        public async Task<List<CountryDto>> GetCountriesAsync()
        {
            var res = await _httpClient.GetAsync("all");
            res.EnsureSuccessStatusCode();
            using var stream = await res.Content.ReadAsStreamAsync();
            var allCountries = await JsonSerializer.DeserializeAsync<List<CountryDto>>(stream, _jsonOptions);
            return allCountries.OrderBy(x => x.Name.Common).ToList();
        }
    }
}
