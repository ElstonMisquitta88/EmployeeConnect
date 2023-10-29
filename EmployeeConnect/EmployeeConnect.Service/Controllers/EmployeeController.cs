using EmployeeConnect.Service.Authorization;
using DataAccess.Data;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeConnect.Service.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeData _data;
        public EmployeeController(IEmployeeData data)
        {
            _data = data;
        }



        [HttpGet]
        [AllowAnonymous]
        [Route("FetchAllEmployees_AllowAnonymous")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmployeeModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> FetchAllEmployees_AllowAnonymous()
        {
            var product = await _data.FetchEmployee("");
            return product == null ? NotFound() : Ok(product);
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



        [HttpPost]
        [Route("SaveEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmployeeModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SaveEmployee(EmployeeModel EmpData)
        {
            string message = string.Empty;
            try
            {
                var product = await _data.SaveEmployee(EmpData);
                message = "Item Successfully Added";
                return Ok(message);

            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }

        }
    }
}
