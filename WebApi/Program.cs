using Application.Common.Mappings;
using Application.Interfaces;
using Application.Services;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Common.Mappings;
using WebApi.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
//(localdb)\MSSQLLocalDB
builder.Services.AddDbContext<AppDBContext>(opt =>
    opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CleanArchDb;Trusted_Connection=True;"));
// Add services to the container.

builder.Services.AddControllers();
//DI theo layer
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

//AutoMapper
builder.Services.AddAutoMapperProfiles();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
