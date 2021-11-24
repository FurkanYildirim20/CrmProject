using AuthCrm.Core.BaseEntity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AuthCrm.DataAccess
{
    public class GenericRepository<TEntity,TContext> : IGenericRepository<TEntity> 
        where TEntity : class, IEntity,  new()
        where TContext :DbContext
    {
        private readonly TContext _context;
        private readonly DbSet<TEntity> _DbSet;
        public GenericRepository(TContext context)
        {
            _context = context;
            _DbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity TEntity)
        {
            _DbSet.Add(TEntity);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _DbSet.Find(id);
        }

        public void Update(TEntity TEntity)
        {
            _DbSet.Update(TEntity);
            _context.SaveChanges();
        }

        public List<TEntity> GetList()
        {
            return _DbSet.ToList();
        }

        public void Delete(int id)
        {
            _DbSet.Remove(GetById(id));
            _context.SaveChanges();
        }

        public virtual IQueryable<TEntity> GetQuery()
        {
            return _DbSet.AsQueryable();
        }
    }
}
