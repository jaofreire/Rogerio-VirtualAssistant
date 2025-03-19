using Rogerio.WEB.Integrations.Interfaces;
using Rogerio.WEB.Integrations.Refit;
using Rogerio.WEB.Integrations.WeatherAPI.Responses;

namespace Rogerio.WEB.Integrations.WeatherAPI
{
    public class WeatherAPIIntegration : IWeatherAPIIntegration
    {
        private readonly IConfiguration _configuration;
        private readonly IWeatherAPIIntegrationRefit _weatherRefit;
        private readonly string _apiKey;

        public WeatherAPIIntegration(IConfiguration configuration, IWeatherAPIIntegrationRefit weatherRefit)
        {
            _configuration = configuration;
            _weatherRefit = weatherRefit;

            _apiKey = _configuration["WeatherAPI:ApiKey"]!;
        }

        public async Task<CurrentWeatherResponse> GetCurrentWeather(string query)
        {
            return await _weatherRefit.GetCurrentWeather(_apiKey, query);
        }
    }
}
