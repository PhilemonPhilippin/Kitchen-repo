using System.Linq.Expressions;

namespace Kitchen.Dal.Interfaces;

public interface IRepository<T>
{
    Task<DbResult<T>> Add(T entity);
    Task<Status> Update(T entity);
    Task<DbResult<T>> Get(int id);
    Task<Status> Delete(int id);
    Task<bool> SaveChanges();
}
