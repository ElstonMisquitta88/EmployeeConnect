using System.Collections.Generic;

namespace EmployeeConnect.Client
{
    public class EmployeeModelService
    {
        public async Task<List<EmployeeModel>?> GetEmployeeAsync()
        {
            using var client = new HttpClient();
            var results = await client.GetFromJsonAsync<List<EmployeeModel>>("https://localhost:7153/api/Employee/FetchAllEmployees");

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
