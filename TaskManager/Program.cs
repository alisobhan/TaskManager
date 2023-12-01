using Domain.Models.Duties;
using Infrastructure.Repository;
using Infrastructure.Repository.Contracts.EntityReposiories;

var builder = WebApplication.CreateBuilder(args);

#region DependecyInjectionServices 

builder.Services.AddScoped<IDutyRepository<Duty>, DutyRepository>();

#endregion



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
