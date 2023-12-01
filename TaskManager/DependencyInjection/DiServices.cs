using Domain.Models.Duties;
using Infrastructure.Repository;
using Infrastructure.Repository.Contracts.EntityReposiories;

namespace TaskManager.DependencyInjection;

public class DiServices
{
	public WebApplicationBuilder Builder { get; set; }
	public DiServices(WebApplicationBuilder builder)
	{
		Builder = builder;
	}


	public void AddScoped()
	{
		Builder.Services.AddScoped<IDutyRepository<Duty>, DutyRepository>();
	}
}
