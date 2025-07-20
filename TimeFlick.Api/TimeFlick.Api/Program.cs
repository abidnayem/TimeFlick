using DinkToPdf;
using DinkToPdf.Contracts;
using TimeFlick.Application;
using TimeFlick.Application.Services;
using TimeFlick.Core.Interfaces;
using TimeFlick.Infrastructure;
using TimeFlick.Infrastructure.Repositories;
using TimeFlick.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure Layer DI registrations
builder.Services.AddInfrastructureDI(builder.Configuration);


// Add Application Layer DI registrations
builder.Services.AddApplicationDI();


// Add services to the container.
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
