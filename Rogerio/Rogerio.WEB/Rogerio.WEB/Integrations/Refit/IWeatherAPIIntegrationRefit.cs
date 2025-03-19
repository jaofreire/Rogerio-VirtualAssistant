using Refit;
using Rogerio.WEB.Integrations.WeatherAPI.Responses;

namespace Rogerio.WEB.Integrations.Refit
{
    public interface IWeatherAPIIntegrationRefit
    {
        [Get("/current.json?key={apiKey}&q={query}")]
        Task<CurrentWeatherResponse> GetCurrentWeather([AliasAs("apiKey")]string apiKey, [AliasAs("query")]string query);
    }
}
