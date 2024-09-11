using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using Shared.Enums;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForcastService weatherForcastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IWeatherForcastService weatherForcastService)
        {
            _logger = logger;
            this.weatherForcastService = weatherForcastService;
        }

        [HttpGet("weatherforecast")]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetWeather()
        {
            var weatherForecast = await weatherForcastService.GetWeather();
            if (weatherForecast == null)
                return BadRequest("No Weather forcast available");

            return Ok(weatherForecast);
        }

        [HttpGet("weatherforecast/{id}")]
        public async Task<ActionResult<WeatherForecast>> GetWeather(int id)
        {
            var weatherForecast = await weatherForcastService.GetWeather(id);
            if (weatherForecast == null)
                return BadRequest("Weather forcast not found");

            return Ok(weatherForecast);
        }

        [HttpPost("weatherforecast")]
        public async Task<ActionResult<ApplicationResult>> AddWeather([FromBody] WeatherForecast weatherForecast)
        {
            ApplicationResult result = await weatherForcastService.AddWeather(weatherForecast);
            if (result == ApplicationResult.Failed)
                return BadRequest("Failed to add Weather forcast");

            return Ok(result);
        }

        [HttpPut("weatherforecast")]
        public async Task<ActionResult<ApplicationResult>> UpdateWeather([FromBody] WeatherForecast weatherForecast)
        {
            ApplicationResult result = await weatherForcastService.UpdateWeather(weatherForecast);
            if (result == ApplicationResult.Failed)
                return BadRequest("Failed to update Weather forcast");

            return Ok(result);
        }

        [HttpDelete("weatherforecast/{id}")]
        public async Task<ActionResult<ApplicationResult>> DeleteWeather([FromQuery] int id)
        {
            ApplicationResult result = await weatherForcastService.DeleteWeather(id);
            if (result == ApplicationResult.Failed)
                return BadRequest("Failed to delete Weather forcast");

            return Ok(result);
        }
    }
}