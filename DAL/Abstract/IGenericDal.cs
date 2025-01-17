using System.Linq.Expressions;

namespace DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task<List<T>> GetAllDalAsync();
        Task<List<T>> GetAllDalAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdDalAsync(Guid id);
        Task<T> CreateDalAsync(T entity);
        Task<T> UpdateDalAsync(T entity);
        Task DeleteDalAsync(T entity);

    }
}
