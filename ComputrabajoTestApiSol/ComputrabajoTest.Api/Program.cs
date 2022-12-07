using ComputrabajoTest.Api.Helpers;
using ComputrabajoTest.Business.BO;
using ComputrabajoTest.Business.Interfaces;
using ComputrabajoTest.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//add databse context
builder.Services.AddDbContext<ComputrabajoTestContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ComputrabajoTestContext"), b => b.MigrationsAssembly("ComputrabajoTest.Api"));
});

builder.Services.AddTransient<IUserBO, UserBO>();

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

//add middleware handlde exceptions
app.ConfigureCustomExceptionHandler();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

