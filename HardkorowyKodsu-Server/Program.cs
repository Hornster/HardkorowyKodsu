using AutoMapper;
using HardkorowyKodsu_Server.Config;
using HardkorowyKodsu_Server.Controllers;
using HardkorowyKodsu_Server.Ctx;
using HardkorowyKodsu_Server.Maps;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Model.VOs;
using HardkorowyKodsu_Server.Repos;
using HardkorowyKodsu_Server.Repos.Interface;
using HardkorowyKodsu_Server.Services;
using HardkorowyKodsu_Server.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<AppSettingsConfigModel>(builder.Configuration.GetSection("Settings"));
builder.Services.AddDbContext<HardkorowyKodsuDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HardkorowyKodsuDbContext"));
});
builder.Services.AddControllers();
builder.Services.AddScoped<IDbStructureRepository, DbStructureRepository>();
builder.Services.AddScoped<IDbStructureService, DbStructureService>();
builder.Services.AddScoped<ISchemaRepository, SchemaRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Ignore SSL certificate validation errors for now.
//REMOVE ON PROD!! :j
ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;


builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<TableNameModel, TableNameVo>();
    cfg.CreateMap<ViewNameModel, TableNameVo>();
    cfg.CreateMap<BaseTableNameModel, TableNameVo>();
    cfg.CreateMap<TableColumnModel, TableColumnVo>();
}, typeof(TableController).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
