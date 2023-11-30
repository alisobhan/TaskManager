using ApplicationService.Duties;
using Domain.Models.Duties;
using Infrastructure.Repository.Contracts.GenericRepository;

namespace Infrastructure.Repository.Contracts.EntityReposiories;

public interface IDutyRepository<TEntity> where TEntity : Duty, IGenericRepository<TEntity>
{
    Task<TEntity> SetTaskAsync(SetDutyCommand command);
    Task<TEntity> SetTaskStatusAsync(SetTaskStatusCommand command);

}
