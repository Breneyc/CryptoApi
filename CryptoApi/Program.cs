using CryptoApi.Domain.Contracts;
using CryptoApi.Repository.Context;
using CryptoApi.Repository.ExternalServices;
using CryptoApi.Repository.Repositories;
using CryptoApi.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configurar servicios CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IFavoriteCryptocurrenciesRepository, FavoriteCryptocurrenciesRepository>();
builder.Services.AddScoped<IFavoriteCryptocurrenciesService, FavoriteCryptocurrenciesService>();
builder.Services.AddHttpClient<IHttpClient, HttpClientService>();
builder.Services.AddTransient<ICryptoCoinGeckoApi, CryptoCoinGeckoApi>();

var app = builder.Build();

// Usar CORS
app.UseCors("AllowAll");

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
