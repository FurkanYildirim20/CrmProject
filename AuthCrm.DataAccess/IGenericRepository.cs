using AuthCrm.Core.BaseEntity;
using System.Collections.Generic;
using System.Linq;

namespace AuthCrm.DataAccess
{
    public interface IGenericRepository<TEntity> where TEntity : class,IEntity, new()
    {
        void Add(TEntity TEntity);
        void Delete(int id);
        void Update(TEntity TEntity);
        public List<TEntity> GetList();
        public IQueryable<TEntity> GetQuery();
        public TEntity GetById(int id);
    }
}
