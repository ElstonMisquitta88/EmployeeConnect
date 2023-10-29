using DataAccess.Data;
using DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeConnect.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeData _data;

        public EmployeeController(IEmployeeData data)
        {
            _data = data;
        }

        [HttpGet]
        [Route("FetchAllEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmployeeModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> FetchAllEmployees()
        {
            var product = await _data.FetchEmployee("");
            return product == null ? NotFound() : Ok(product);
        }
    }
}
