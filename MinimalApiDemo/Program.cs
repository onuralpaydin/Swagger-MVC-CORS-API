var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //boilerplate code
};
//weatherforecastcontroller içindeki veriler burada. mapget ile almış
app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
//isimlendirmiş.
//Çalıştırdığında görünürde bir farklılık yok.
//sadece kodun yazım şekli farklı. Enduser kısmında fark yok.
//neden minimal api var ? controllerda vs olan veriler program.cs içinde 1-2 satır kodda.
//app.MapPost
//app.MapPut
//kendimiz methodumuzu yazıp mapleyebiliyoruz
app.MapGet("deneme", () => "Hello World");
//mikroservis yazarken minimal api faydalı. yer kaplamıyor her şey göz önünde vs.

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}