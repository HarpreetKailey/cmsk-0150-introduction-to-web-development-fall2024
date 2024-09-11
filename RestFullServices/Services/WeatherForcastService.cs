using Domain;
using Repositories;
using Shared.Enums;

namespace Services
{
    public class WeatherForcastService : IWeatherForcastService
    {
        private readonly IWeatherForcastRepository weatherForcastRepository;
        private readonly IPersonRepository personRepository;

        public WeatherForcastService(IWeatherForcastRepository weatherForcastRepository, IPersonRepository personRepository)
        {
            this.weatherForcastRepository = weatherForcastRepository;
            this.personRepository = personRepository;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            return await weatherForcastRepository.GetWeather();
        }

        public async Task<WeatherForecast> GetWeather(int id)
        {
            return await weatherForcastRepository.GetWeather(id);
        }

        public async Task<ApplicationResult> AddWeather(WeatherForecast weatherForecast)
        {
            return await weatherForcastRepository.AddWeather(weatherForecast);
        }

        public async Task<ApplicationResult> UpdateWeather(WeatherForecast weatherForecast)
        {
            return await weatherForcastRepository.UpdateWeather(weatherForecast);
        }

        public async Task<ApplicationResult> DeleteWeather(int id)
        {
            return await weatherForcastRepository.DeleteWeather(id);
        }
    }
}