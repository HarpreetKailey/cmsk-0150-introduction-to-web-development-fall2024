using Domain;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Shared.Enums;

namespace Data
{
    public class WeatherForcastRepository : IWeatherForcastRepository
    {
        private readonly ApiDataContext apiDataContext;

        public WeatherForcastRepository(ApiDataContext apiDataContext)
        {
            this.apiDataContext = apiDataContext;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            return await apiDataContext.WeatherForecasts.ToListAsync();
        }

        public async Task<WeatherForecast> GetWeather(int id)
        {
            return await apiDataContext.WeatherForecasts.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ApplicationResult> AddWeather(WeatherForecast weatherForecast)
        {
            if (weatherForecast == null)
                return ApplicationResult.Failed;

            apiDataContext.WeatherForecasts.Add(weatherForecast);
            await apiDataContext.SaveChangesAsync();

            return ApplicationResult.Success;
        }

        public async Task<ApplicationResult> UpdateWeather(WeatherForecast weatherForecast)
        {
            apiDataContext.Update(weatherForecast);
            await apiDataContext.SaveChangesAsync();

            return ApplicationResult.Success;
        }

        public async Task<ApplicationResult> DeleteWeather(int id)
        {
            var weatherForecast = await GetWeather(id);
            if (weatherForecast == null)
                return ApplicationResult.Failed;

            apiDataContext.WeatherForecasts.Remove(weatherForecast);
            await apiDataContext.SaveChangesAsync();

            return ApplicationResult.Success;
        }
    }
}