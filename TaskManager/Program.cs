using Infrastructure.Data.Servers;
using Infrastructure.Repository;
using Infrastructure.Repository.Contracts.EntityReposiories;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddScoped<>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
