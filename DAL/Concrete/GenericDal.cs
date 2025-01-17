using DAL.Abstract;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace DAL.Concrete
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        private readonly EasyCashContext _context;

        public GenericDal(EasyCashContext context)
        {
            _context = context;
        }

        public async Task<T> CreateDalAsync(T entity)
        {
            try
            {
                EntityEntry<T> createdEntity = await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return createdEntity.Entity;
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception($"Error creating entity: {ex.Message}", ex);
            }
        }

        public async Task DeleteDalAsync(T entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _context.Set<T>().Attach(entity);
                }
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception($"Error deleting entity: {ex.Message}", ex);
            }
        }

        public async Task<List<T>> GetAllDalAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception($"Error retrieving entities: {ex.Message}", ex);
            }
        }

        public async Task<List<T>> GetAllDalAsync(Expression<Func<T, bool>> filter)
        {
            try
            {
                return await _context.Set<T>().Where(filter).ToListAsync();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception($"Error retrieving filtered entities: {ex.Message}", ex);
            }
        }

        public async Task<T> GetByIdDalAsync(Guid id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception($"Error retrieving entity by id: {ex.Message}", ex);
            }
        }

        public async Task<T> UpdateDalAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception($"Error updating entity: {ex.Message}", ex);
            }
        }
    }
}
