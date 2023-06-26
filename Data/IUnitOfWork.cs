namespace BoltBit.Core.Data;

public interface IUnitOfWork : IAsyncDisposable
{
    IRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntity;
    Task<int> SaveChangesAsync();
    int SaveChanges();
}