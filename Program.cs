using AgendaAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = builder.Environment;  // Obtém o ambiente atual da aplicação

// Configuração da fonte de configuração
var configuration = new ConfigurationBuilder()
    .SetBasePath(env.ContentRootPath)  // Define o diretório base para buscar os arquivos de configuração
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
    // Adiciona o arquivo de configuração específico do ambiente (por exemplo, appsettings.Development.json)
    .Build();  // Constrói a configuração com base nos arquivos de configuração

// Configuração da injeção de dependência para o DbContext do Entity Framework
builder.Services.AddDbContext<AgendaContext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));
// Configura a conexão do banco de dados com base na configuração


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
