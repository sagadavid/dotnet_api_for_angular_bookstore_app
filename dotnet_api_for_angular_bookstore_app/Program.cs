using Microsoft.EntityFrameworkCore;
using BookstoreApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BookstoreApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookstoreApiContext") ?? throw new InvalidOperationException("Connection string 'BookstoreApiContext' not found.")));
builder.Services.AddDbContext<BookstoreApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dotnet_api_for_angular_bookstore_appContext") ?? throw new InvalidOperationException("Connection string 'dotnet_api_for_angular_bookstore_appContext' not found.")));

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
