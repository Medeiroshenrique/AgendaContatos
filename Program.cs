using AgendaAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = builder.Environment;  

var configuration = new ConfigurationBuilder()
    .SetBasePath(env.ContentRootPath)  
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
    .Build();

builder.Services.AddDbContext<AgendaContext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));


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
