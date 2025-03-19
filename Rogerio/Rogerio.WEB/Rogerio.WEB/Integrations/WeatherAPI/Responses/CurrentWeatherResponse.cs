namespace Rogerio.WEB.Integrations.WeatherAPI.Responses
{
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Localtime { get; set; }
    }

    public class CurrentWeather
    {
        public long Last_Updated_Epoch { get; set; }
        public string Last_Updated { get; set; }
        public float Temp_C { get; set; }
        public float Temp_F { get; set; }

    }

    public class CurrentWeatherResponse
    {
        public Location? Location { get; set; }
        public CurrentWeather? Current { get; set; }
    }
}
