using ApplicationService.Duties;
using Domain.Common;
using Domain.Models.Duties;
using Infrastructure.Repository.Contracts.GenericRepository;

namespace Infrastructure.Repository.Contracts.EntityReposiories;

public interface IDutyRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> SetTaskAsync(SetDutyCommand command);
    Task<TEntity> SetTaskStatusAsync(SetTaskStatusCommand command);

}
