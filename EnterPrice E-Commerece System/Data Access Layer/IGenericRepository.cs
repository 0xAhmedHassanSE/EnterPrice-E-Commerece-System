

using Microsoft.EntityFrameworkCore;

namespace EnterPrice_E_Commerece_System.CRUD
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public IEnumerable<T> GetAll(Func<T, bool> predicate);
        public Task AddAsync(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public  Task AddRangeAsync(IEnumerable<T> data); 
    }
}
