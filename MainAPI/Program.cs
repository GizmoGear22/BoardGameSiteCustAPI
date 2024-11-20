using DataLayer;
using DataLayer.DataHandlers;
using LogicLayer.APILogic;
using LogicLayer.DBLogic;
using Microsoft.EntityFrameworkCore;
using ValidationLayer.Middleware;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "X-Api-Key",
        Type = SecuritySchemeType.ApiKey,
        Description = "Input API Key here"

    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
		{
			new OpenApiSecurityScheme
			{
				Reference = new OpenApiReference
				{
					Type = ReferenceType.SecurityScheme,
					Id = "ApiKey"
				}
			},
			Array.Empty<string>()
		}
	});
    }
);


//DI services
builder.Services.AddTransient<IDBHandlers, DBHandlers>();
builder.Services.AddTransient<IDBLogicHandlers, DBLogicHandlers>();
builder.Services.AddTransient<IAPILogicHandlers, APILogicHandlers>();

builder.Services.AddDbContext<DataAccessPoint>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbCnnString")));

//CORS

builder.Services.AddCors(options => options.AddDefaultPolicy(
	builder => builder.AllowCredentials().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ApiMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
