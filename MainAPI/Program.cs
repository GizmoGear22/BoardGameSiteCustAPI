using DataLayer;
using DataLayer.DataHandlers;
using LogicLayer.APILogic;
using LogicLayer.DBLogic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DI services
builder.Services.AddTransient<IDBHandlers, DBHandlers>();
builder.Services.AddTransient<IDBLogicHandlers, DBLogicHandlers>();
builder.Services.AddTransient<IAPILogicHandlers, APILogicHandlers>();

builder.Services.AddDbContext<DataAccessPoint>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbCnnString")));

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
