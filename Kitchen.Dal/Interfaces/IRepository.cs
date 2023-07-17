using System.Linq.Expressions;

namespace Kitchen.Dal.Interfaces;

public interface IRepository<T>
{
    Task<T?> Add(T entity);
    Task<bool> Update(T entity);
    Task<T?> Get(int id);
    Task<bool> Delete(int id);
    Task<bool> SaveChanges();
}
