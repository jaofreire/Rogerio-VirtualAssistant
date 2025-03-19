using Rogerio.WEB.Integrations.WeatherAPI.Responses;

namespace Rogerio.WEB.Integrations.Interfaces
{
    public interface IWeatherAPIIntegration
    {
        Task<CurrentWeatherResponse> GetCurrentWeather(string query);
    }
}
