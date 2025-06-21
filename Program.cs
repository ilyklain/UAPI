using UsuariosAPI.Services;
using Microsoft.EntityFrameworkCore;
using UsuariosAPI.Data;
using UsuariosAPI.Models;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("UsuariosDB"));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
