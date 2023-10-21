using DataAccess.Data;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeConnectApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IEmployeeData _data;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEmployeeData data)
        {
            _logger = logger;
            _data = data;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{

        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //[HttpGet]
        //[Route("GetWeatherForecastV1")]
        //public IActionResult GetWeatherForecastV1()
        //{

        //    return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray());
        //}


        [HttpGet]
        [Route("FetchEmployee/{Search}")]
        public Task<IEnumerable<EmployeeModel>> FetchEmployee(string Search)
        {

            return _data.FetchEmployee(Search);
        }
    }
}