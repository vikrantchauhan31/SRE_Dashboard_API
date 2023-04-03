using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SRE_Dashboard_API.Models;

namespace SRE_Dashboard_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public static async Task<ExampleData> GetApiData()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY");
                HttpResponseMessage response = await client.GetAsync("https://api.example.com/data");
                string responseBody = await response.Content.ReadAsStringAsync();
                ExampleData exampleData = JsonConvert.DeserializeObject<ExampleData>(responseBody);
                return exampleData;
            }
        }
    }
}