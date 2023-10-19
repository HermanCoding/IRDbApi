using Microsoft.EntityFrameworkCore;
using IRDbApi.Database;
using IRDbApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Fetch connection string
var connectionString = builder.Configuration.GetConnectionString("IrDbConnection");
// Add AppDbContext to DB-container
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// To change reppository update to the new repository in the code below
builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();

// Not a safe way to give access
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "AllowAll", policy =>
	{
		policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
