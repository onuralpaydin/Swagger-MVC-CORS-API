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
//weatherforecastcontroller i�indeki veriler burada. mapget ile alm��
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
//isimlendirmi�.
//�al��t�rd���nda g�r�n�rde bir farkl�l�k yok.
//sadece kodun yaz�m �ekli farkl�. Enduser k�sm�nda fark yok.
//neden minimal api var ? controllerda vs olan veriler program.cs i�inde 1-2 sat�r kodda.
//app.MapPost
//app.MapPut
//kendimiz methodumuzu yaz�p mapleyebiliyoruz
app.MapGet("deneme", () => "Hello World");
//mikroservis yazarken minimal api faydal�. yer kaplam�yor her �ey g�z �n�nde vs.

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}