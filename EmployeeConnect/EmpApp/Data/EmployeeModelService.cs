using System.Collections.Generic;

namespace EmpApp.Data
{
    public class EmployeeModelService
    {
        public async Task<List<EmployeeModel>?> GetEmployeeAsync()
        {
            using var client = new HttpClient();
            var results = await client.GetFromJsonAsync<List<EmployeeModel>>("https://localhost:7248/WeatherForecast/FetchEmployee/d");

            if (results == null)
            {
                return null;
            }
            else
            {
                return results;
            }
        }
    }
}
