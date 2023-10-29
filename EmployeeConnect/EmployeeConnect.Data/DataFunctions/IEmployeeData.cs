using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IEmployeeData
    {
        Task<IEnumerable<EmployeeModel>> FetchEmployee(string SearchText);
    }
}
