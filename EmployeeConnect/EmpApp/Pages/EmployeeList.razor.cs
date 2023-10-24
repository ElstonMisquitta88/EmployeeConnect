using EmpApp.Data;

namespace EmpApp.Pages
{

    public partial class EmployeeList
    {
        private List<EmployeeModel>? EmplData;
        private EmployeeModel EmpInput { get; set; } = new EmployeeModel();





        protected override async Task OnInitializedAsync()
        {
           EmplData = await EmployeeService.GetEmployeeAsync();
        }

        void FormSubmitted()
        {
            // Link to read : https://blazor-university.com/forms/
            //https://www.syncfusion.com/blogs/post/blazor-forms-and-form-validation.aspx 
            string? a = EmpInput.FirstName;
            // Post data to the server, etc
        }
    }
}