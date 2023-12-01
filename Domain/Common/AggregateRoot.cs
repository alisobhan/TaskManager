namespace Domain.Common;

public abstract class AggregateRoot<TEntity>
{
    public TEntity Id { get; protected set; }
}
