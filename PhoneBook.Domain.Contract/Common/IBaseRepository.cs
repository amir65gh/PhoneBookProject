using PhoneBook.Domain.Core;
using System.Linq;

namespace PhoneBook.Domain.Contract.Common
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        void Delete(int id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
