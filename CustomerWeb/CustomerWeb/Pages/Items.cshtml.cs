using CustomerWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerWeb.Pages
{
    public class ItemsModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ItemsModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<TrainModel> Trains { get; set; }

        public async Task OnGetAsync()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync("https://example.com/api/trains");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Trains = JsonSerializer.Deserialize<List<TrainModel>>(content);
            }
            else
            {
                // Handle error
                Trains = new List<TrainModel>();
            }
        }
    }
        }
