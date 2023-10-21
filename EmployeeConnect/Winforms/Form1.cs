using System.Net.Http.Json;
using System.Diagnostics;
using Serilog;

namespace Winforms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Information("Getting ready to do something.");
                using var client = new HttpClient();
                var results = await client.GetFromJsonAsync<List<EmployeeModel>>("https://localhost:7248/WeatherForecast/FetchEmployee/d");
                
                Log.Information("Data Fetched");
                if (results == null)
                {

                }
                else
                {
                    List<EmployeeModel> Lst = results.ToList();
                    dataGridView1.DataSource = Lst;
                    Log.Information("Data Load Complete");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Form1_Load");
                throw;
            }
        }
    }

    public class EmployeeModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public int MobileNo { get; set; }
    }
}