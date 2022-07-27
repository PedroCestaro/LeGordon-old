using Legordon.Adm.Api.Infrastructure.IoC;
using AutoMapper;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ApplicationDI.RegisterApplicationServices(builder.Services);
CqrsDI.ConfigureCQRSServices(builder.Services);
EntityServicesDI.RegisterEntityServices(builder.Services);  



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
