using EmpApp.Data;

namespace EmpApp.Pages
{

    public partial class EmployeeList
    {
        private List<EmployeeModel>? EmplData;
        private EmployeeModel Els { get; set; } = new EmployeeModel();
        protected override async Task OnInitializedAsync()
        {
            EmplData = await EmployeeService.GetEmployeeAsync();
        }
    }
}