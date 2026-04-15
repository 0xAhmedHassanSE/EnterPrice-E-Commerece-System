using EnterPrice_E_Commerece_System.Data;
using Microsoft.EntityFrameworkCore;

namespace EnterPrice_E_Commerece_System.CRUD
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        readonly EnterPriseContext context;
        public GenericRepository(EnterPriseContext enterPriseContext)
        {
            context = enterPriseContext ?? throw new ArgumentNullException(nameof(enterPriseContext),
                "Database context cannot be null");
        }

        public async Task AddAsync(T entity) => await context.AddAsync(entity);

        public void Delete(T entity) => context.Remove(entity);

        public async Task<IEnumerable<T>> GetAllAsync() => await context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await context.Set<T>().FindAsync(id) ??
            throw new NullReferenceException("There is no Row has this id in the table");
        public void Update(T entity) => context.Update(entity);


    }
}
