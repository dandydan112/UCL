using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherForecastMVC.Models; // You'll create this model to match the API response

public class WeatherController : Controller
{
    private readonly HttpClient _httpClient;

    public WeatherController()
    {
        _httpClient = new HttpClient();
    }

    public async Task<IActionResult> Index()
    {
        string apiUrl = "https://localhost:7243/WeatherForecast"; // This is the URL of your API
        var response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var weatherData = JsonConvert.DeserializeObject<List<WeatherForecast>>(jsonData); // Deserialize to your model
            return View(weatherData); // Pass the data to the view
        }

        return View("Error"); // Handle errors
    }
}
