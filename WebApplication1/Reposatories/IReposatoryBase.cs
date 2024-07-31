using System.Linq.Expressions;
using WebApplication1.Models.models;

namespace WebApplication1.Reposatories
{
    public interface IReposatoryBase<T> where T : BaseModel
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T GetByID(int id);
       
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void SaveChanges();
    }
}
