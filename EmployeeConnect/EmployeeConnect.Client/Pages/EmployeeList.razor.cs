using Microsoft.AspNetCore.Components;
namespace EmployeeConnect.Client.Pages
{
    public partial class EmployeeList
    {
        private List<EmployeeConnect.Client.EmployeeModel>? EmplDataList;

        [Inject]
        private EmployeeConnect.Client.EmployeeModelService? EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EmplDataList = await EmployeeService.GetEmployeeAsync();
        }


    }
}