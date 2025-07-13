using DinkToPdf;
using DinkToPdf.Contracts;
using TimeFlick.Core.Interfaces;
using TimeFlick.Infrastructure;
using TimeFlick.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the PDF generator
//builder.Services.AddScoped<IPdfGenerator, SelectPdfGenerator>();
// Move this line:
builder.Services.AddInfrastructure();
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
