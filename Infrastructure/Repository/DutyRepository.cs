using ApplicationService.Duties;
using Domain.Models.Duties;
using Infrastructure.Data.Servers;
using Infrastructure.Repository.Contracts.EntityReposiories;
using Infrastructure.Repository.Contracts.GenericRepository;

namespace Infrastructure.Repository;

public class DutyRepository : ApplicationDbContext
{
    private readonly ApplicationDbContext _applicationDbContext;
    public DutyRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async IEnumerable<Duty> GetAll()
    {
        var List = await _applicationDbContext.;
        return List;
    }

    public async Duty GetBy(int Id)
    {
        Duty duty = await _duyRepository.GetById(Id);
        return duty;
    }

    public async void Insert(Duty entity)
    {
        object value = await _applicationDbContext.Add(entity);
        _applicationDbContext.SaveChanges();
    }

    public void Remove(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Duty> SetTaskAsync(SetDutyCommand command)
    {
        await _applicationDbContext.Add()
    }

    public Task<Duty> SetTaskStatusAsync(SetTaskStatusCommand command)
    {
        throw new NotImplementedException();
    }

    public void Update(Duty entity)
    {
        throw new NotImplementedException();
    }
}
