using ApplicationService.Duties;
using Domain.Models.Duties;
using Infrastructure.Data.Servers;
using Infrastructure.Repository.Contracts.EntityReposiories;
using Infrastructure.Repository.Contracts.GenericRepository;

namespace Infrastructure.Repository;

public class DutyRepository /*: IDutyRepository<Duty>*/
{
    private readonly ApplicationDbContext _applicationDbContext;
    public DutyRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    
}
