using Domain;
using Shared.Enums;

namespace Services
{
    public interface IWeatherForcastService
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
        Task<WeatherForecast> GetWeather(int id);
        Task<ApplicationResult> AddWeather(WeatherForecast weatherForecast);
        Task<ApplicationResult> UpdateWeather(WeatherForecast weatherForecast);
        Task<ApplicationResult> DeleteWeather(int id);
    }
}