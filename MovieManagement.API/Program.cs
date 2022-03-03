using Microsoft.EntityFrameworkCore;
using MovieManagement.API.Data;
using MovieManagement.API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Add the COnfiguration
ConfigurationManager configuration = builder.Configuration;

// Registering a Database
builder.Services.AddDbContext<MovieDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

//Registering Repository
builder.Services.AddScoped<IMovieRepository, MovieDbRepository>();
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
