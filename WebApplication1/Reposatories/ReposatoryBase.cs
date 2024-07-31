using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication1.Models;
using WebApplication1.Models.models;

namespace WebApplication1.Reposatories
{
    public class ReposatoryBase<T> : IReposatoryBase<T> where T : BaseModel
    {

        Context _context;

        public ReposatoryBase(Context context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        { 
            entity.Deleted = true;
            Update(entity);
        }

        public void Delete(int id)
        {
            T entity = _context.Find<T>(id);
            Delete(entity);
        }



        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().Where(x => !x.Deleted).AsNoTracking();
         
        }

        public T GetByID(int id)
        {
          var data = GetAll().FirstOrDefault(x => x.ID == id);
            if (data != null)
            {
                return data;
            }
            else {
                return null;
            }
           
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
