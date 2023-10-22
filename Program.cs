using AgendaAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = builder.Environment;  // Obt�m o ambiente atual da aplica��o

// Configura��o da fonte de configura��o
var configuration = new ConfigurationBuilder()
    .SetBasePath(env.ContentRootPath)  // Define o diret�rio base para buscar os arquivos de configura��o
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
    // Adiciona o arquivo de configura��o espec�fico do ambiente (por exemplo, appsettings.Development.json)
    .Build();  // Constr�i a configura��o com base nos arquivos de configura��o

// Configura��o da inje��o de depend�ncia para o DbContext do Entity Framework
builder.Services.AddDbContext<AgendaContext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));
// Configura a conex�o do banco de dados com base na configura��o


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
