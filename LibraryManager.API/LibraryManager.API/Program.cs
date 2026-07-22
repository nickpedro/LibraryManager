using LibraryManager.API.Data;
using Microsoft.EntityFrameworkCore;
using LibraryManager.API.Interfaces;
using LibraryManager.API.Repositories;
using LibraryManager.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Injeção de Dependência do DbContext para o SQL Server
builder.Services.AddDbContext<LibraryDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivroService, LivroService>();

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
