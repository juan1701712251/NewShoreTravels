using NewShoreTravels.App.Business.Interfaces;
using NewShoreTravels.App.Business.Services;
using NewShoreTravels.App.DataAccess.Context;
using NewShoreTravels.App.DataAccess.Interfaces;
using NewShoreTravels.App.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NewShoreTravelsDbContext>();
builder.Services.AddTransient<IJourneyRepository, JourneyRepository>();
builder.Services.AddTransient<IJourneyService, JourneyService>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
