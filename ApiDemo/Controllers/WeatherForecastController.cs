using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    //gideceðim path yol link nedir? route controller adýný al demiþ . zaten biz de weatherforecast yazdýðýmýzda bilgiye ulaþtýk.
    [Route("api/[controller]")]
    //linki deðiþtirdim. projeyi çalýþtýrýnca get isteðindeki link deðiþti.

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        //httpGET istek attýk. bildiðimiz þey.
        [HttpGet(Name = "GetWeatherForecast")]//þurasý documentation için.Kendimiz yazarken de isimlendirme önemli. Tahmin edilebilir anlaþýlabilir olmalý.
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}