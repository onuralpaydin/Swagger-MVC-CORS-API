var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options => options.AddPolicy("AllowOrigin", option => option.AllowAnyOrigin())); //herkese apiye ulaþma yetkisi verdik.
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//bunu da eklemek lazým.
app.UseCors(a=>

{
    a.AllowAnyHeader();
    a.AllowAnyMethod();
    a.AllowAnyOrigin();
}
);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
