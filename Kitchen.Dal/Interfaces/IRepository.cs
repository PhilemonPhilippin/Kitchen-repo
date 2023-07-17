using System.Linq.Expressions;

namespace Kitchen.Dal.Interfaces;

public interface IRepository<T>
{
    Task<T?> Add(T entity);
    Task<bool> Update(T entity);
    Task<T?> Get(int id);
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    Task<bool> Delete(int id);
}
