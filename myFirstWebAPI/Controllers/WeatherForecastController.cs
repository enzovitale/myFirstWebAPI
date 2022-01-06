using Microsoft.AspNetCore.Mvc;

using static myFirstWebAPI.WeatherForecastHelpers;


namespace myFirstWebAPI.Controllers
{
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        public IEnumerable<WeatherForecast> Get() => RandomForecasts();
    }
}