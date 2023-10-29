using DataAccess.DbAccess;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    // Implementation
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess _db;
        public EmployeeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<IEnumerable<EmployeeModel>> FetchEmployee(string _SearchText)
        {
            return await _db.FetchData<EmployeeModel, dynamic>("Proc_GetEmployee", new { SearchText = _SearchText }, "Default");
        }

    }
}
