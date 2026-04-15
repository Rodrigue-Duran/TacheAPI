using Microsoft.EntityFrameworkCore;
using TacheAPI.Data;
using TacheAPI.Repositories;
using TacheAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Ajouter le AppDbContext pour Sqlite sans chaine de connection
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=taches.db"));

// Ajouter les sous classes des interfaces IRepository et IService
builder.Services.AddScoped<ITacheRepository, TacheRepository>();
builder.Services.AddScoped<ITacheService, TacheService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
