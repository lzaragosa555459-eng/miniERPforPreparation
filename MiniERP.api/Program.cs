using Microsoft.EntityFrameworkCore;
using MiniERP.Infrastructure.Data;
using MiniERP.Company.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MasterErpDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("MasterErp")));

builder.Services.AddDbContext<RepairShopDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("CompanyDb")));
// Add services to the container.

builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

