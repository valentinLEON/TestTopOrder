using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestTopOrder.Data
{
    public class CountryDto
    {
        [JsonPropertyName("name")]
        public NameDto Name { get; set; }

        [JsonPropertyName("independent")]
        public bool Independent { get; set; }

        [JsonPropertyName("currencies")]
        public Dictionary<string, CurrencyDto> Currencies { get; set; } = new();

        [JsonPropertyName("capital")]
        public List<string> Capital { get; set; } = new();

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("flags")]
        public FlagDto Flags { get; set; }

        [JsonPropertyName("population")]
        public long Population { get; set; }

        [JsonPropertyName("continents")]
        public List<string> Continents { get; set; }

        [JsonPropertyName("languages")]
        public Dictionary<string, string> Languages { get; set; } = new();
    }

    public class NameDto
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }
        [JsonPropertyName("official")]
        public string Official { get; set; }
    }

    public class FlagDto
    {
        [JsonPropertyName("png")]
        public string Png { get; set; }
        [JsonPropertyName("svg")]
        public string Svg { get; set; }

        [JsonPropertyName("alt")]
        public string Alt { get; set; }

    }

    public class CurrencyDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }

}
