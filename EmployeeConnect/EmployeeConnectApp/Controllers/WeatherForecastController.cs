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


        [HttpGet]
        [Route("FetchEmployee/{Search}")]
        public Task<IEnumerable<EmployeeModel>> FetchEmployee(string Search)
        {

            return _data.FetchEmployee(Search);
        }
    }
}