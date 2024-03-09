using SearchVehicles.Application.SearchVehicles;
using SearchVehicles.Domain.Interfaces.Repositories;
using SearchVehicles.Domain.Interfaces.Services;
using SearchVehicles.Infrastructure.Data.DBContext;
using SearchVehicles.Infrastructure.Repositories;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDBContextSQL, DBContextSQL>();
builder.Services.AddScoped<ISearchVehiclesService, SearchVehiclesService>();
builder.Services.AddScoped<ISearchVehiclesRepository, SearchVehiclesRepository>();

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
