using Domain.Common;

namespace Infrastructure.Repository.Contracts.GenericRepository;

public interface IGenericRepository<TEntity> where TEntity : class
{
    #region Read
    IEnumerable<TEntity> GetAll();
    TEntity GetBy(int Id);
    #endregion

    #region Write
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Remove(int Id);
    #endregion

}
