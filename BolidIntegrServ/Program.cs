using Microsoft.EntityFrameworkCore;
using BolidIntegrServ.Data;

var builder = WebApplication.CreateBuilder(args);

var orionContext = builder.Configuration.GetConnectionString("OrionConnection") ?? 
                   throw new InvalidOperationException("Connection string 'OrionConnection' not found.");

builder.Services.AddDbContext<OrionDbContext>(options =>
    options.UseSqlServer(orionContext));

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