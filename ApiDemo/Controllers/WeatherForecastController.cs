using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    //gidece�im path yol link nedir? route controller ad�n� al demi� . zaten biz de weatherforecast yazd���m�zda bilgiye ula�t�k.
    [Route("api/[controller]")]
    //linki de�i�tirdim. projeyi �al��t�r�nca get iste�indeki link de�i�ti.

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
        //httpGET istek att�k. bildi�imiz �ey.
        [HttpGet(Name = "GetWeatherForecast")]//�uras� documentation i�in.Kendimiz yazarken de isimlendirme �nemli. Tahmin edilebilir anla��labilir olmal�.
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