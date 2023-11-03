using ETicaretAPI.Persistance;
using ETicaretAPI.Persistance.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ETicaretAPIContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
}, ServiceLifetime.Singleton);

builder.Services.AddPersistanceServices();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
