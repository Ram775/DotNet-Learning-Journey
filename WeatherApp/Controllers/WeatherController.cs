using Microsoft.AspNetCore.Mvc;
using  System.Net.Http;
using System.Threading.Tasks;


[ApiController]
[Route("/api/weather")]
public class WeatherController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public WeatherController()
    {
        _httpClient = new HttpClient();

    }

    [HttpGet ("{city}")]
    public async Task<IActionResult> GetWeather(string city)
    {
        string apiKey = "4529c4948f320ce4b3c04139225c6c38";

        string url  = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        var responce = await _httpClient.GetAsync(url);
        var data = await responce.Content.ReadAsStringAsync();

        return Ok(data);
    }
}