using PhoneBook.Domain.Contract.Common;
using PhoneBook.Domain.Core;
using System.Linq;

namespace PhoneBook.Infrastructure.DataLayer.Common
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
         where TEntity : BaseEntity, new()

    {
        private readonly PhoneBookContext _context;
        public BaseRepository(PhoneBookContext context)
        {
            _context = context;
        }
        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return _context.Find<TEntity>(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsQueryable();

        }

        public TEntity Update(TEntity entity)
        {
            _context.Update<TEntity>(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
